/**
 * Form1
 * Non-requested GUI to test out components
 **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CookieMonster
	{
	public partial class Form1 : Form
		{
		private const int INIT_BAKECOOKIES = 10;
		private const string ERRMSG_BAKECOOKIE = "There was an Error Baking a Cookie: {0}";
		private const string ERRMSG_TAKECOOKIE = "There was an Error Taking a Cookie: {0}";

		private CookieMonster g_CookieMonster;
		private CookieMaker g_CookieMaker;
		private CookieJar g_CookieJar;


		public Form1()
			{
			InitializeComponent();

			// init base classes
			g_CookieJar = new CookieJar();
			g_CookieJar.CookieAdded += CookieJarAddedOccurred;
			g_CookieJar.CookieTaken += CookieJarRemovedOccurred;

			g_CookieMonster = new CookieMonster("George");
			g_CookieMonster.CookieMonsterAction += CookieMakerActionOccurred;

			g_CookieMaker = new CookieMaker("MyCookieMaker", 0, (ICookieJar)g_CookieJar);
			g_CookieMaker.CookieBaking += CookieMakerActionOccurred;


			// init cookie maker flavors dropdown
			cbCookieFlavors.Items.Add("* Random Flavor *");
			cbCookieFlavors.Items.AddRange( g_CookieMaker.GetAvailableCookieFlavors() );
			cbCookieFlavors.SelectedIndex = 0;
			}

		#region Form Events
		//-------------------
		private void Form1_Shown(object sender, EventArgs e)
			{
			btnEatCookie.Select();

			// lets bake some cookies to get started
			try
				{
				for (int i = 0; i < INIT_BAKECOOKIES; i++)
					g_CookieJar.AddCookie(g_CookieMaker.BakeCookie());
				}
			catch (Exception ex)
				{
				MessageBox.Show(this, string.Format(ERRMSG_BAKECOOKIE, ex.Message));
				}
			}

		//-------------------
		private void button2_Click(object sender, EventArgs e)
			{
			this.Close();
			}

		//-------------------
		private void btnEatCookie_Click(object sender, EventArgs e)
			{
			try
				{
				g_CookieMonster.TakeCookie(CookieAction.Eat, (ICookieJar)g_CookieJar);
				}
			catch(Exception ex)
				{
				MessageBox.Show( this, string.Format(ERRMSG_TAKECOOKIE, ex.Message ) );
				}
			finally
				{ 
				}
			}

		//-------------------
		private void btnThrowAwayCookie_Click(object sender, EventArgs e)
			{
			try
				{
				g_CookieMonster.TakeCookie( CookieAction.ThrowAway, (ICookieJar)g_CookieJar);
				}
			catch (Exception ex)
				{
				MessageBox.Show(this, string.Format(ERRMSG_TAKECOOKIE, ex.Message));
				}
			finally
				{
				}
			}

		//-------------------
		private void btnPutBackCookie_Click(object sender, EventArgs e)
			{
			try
				{
				g_CookieMonster.TakeCookie(CookieAction.PutBack, (ICookieJar)g_CookieJar);
				}
			catch (Exception ex)
				{
				MessageBox.Show(this, string.Format(ERRMSG_TAKECOOKIE, ex.Message));
				}
			finally
				{
				}
			}

		//-------------------
		private void btnBakeACookie_Click(object sender, EventArgs e)
			{
			try
				{
				g_CookieJar.AddCookie ( g_CookieMaker.BakeCookie( cbCookieFlavors.SelectedItem.ToString() ) );
				}
			catch( Exception ex )
				{
				MessageBox.Show(this, string.Format(ERRMSG_BAKECOOKIE, ex.Message));
				}
			}
		#endregion Form Events


		#region callbacks for control displays
		// event callback for cookie jar actions
		delegate void SetCookieJarAddedCallback( ICookie cookie );
		delegate void SetCookieJarRemovedCallback();

		private void CookieJarAddedOccurred(ICookie cookie)
			{
			// if sent from thread other than UI we must invoke
			if (this.lblCookieJarStatus.InvokeRequired)
				{
				SetCookieJarAddedCallback d = new SetCookieJarAddedCallback(CookieAddedToJar);
				this.Invoke(d, new object[] { cookie });
				}
			else
				CookieAddedToJar( cookie );
			}

		private void CookieJarRemovedOccurred()
			{
			// if sent from thread other than UI we must invoke
			if (this.lblCookieJarStatus.InvokeRequired)
				{
				SetCookieJarRemovedCallback d = new SetCookieJarRemovedCallback(CookieRemovedFromJar);
				this.Invoke(d, new object[] { });
				}
			else
				CookieRemovedFromJar();
			}

				
		private void CookieAddedToJar( ICookie cookie )
			{
			ListViewItem item = lvCookieJar.Items.Insert( 0, new ListViewItem( cookie.BakeTime.ToString("hh:mm:ss") ) );
			item.SubItems.Add( cookie.Flavor );
			SetCookieJarStatus();
			}

		private void CookieRemovedFromJar()
			{
			// for this demo cookies are removed from the top of the jar (LIFO)
			if ( lvCookieJar.Items.Count > 0 )
				lvCookieJar.Items.RemoveAt( 0 );
			SetCookieJarStatus();
			}

		private void SetCookieJarStatus()
			{
			lblCookieJarStatus.Text = string.Format( "{0} Total Cookies", g_CookieJar.GetCookieCount() );
			}

		// event callback for cookie maker actions
		delegate void SetCookieMakerLabelCallback(string action, string flavor);
		private void CookieMakerActionOccurred( string action, string flavor )
			{
			// if sent from thread other than UI we must invoke
			if (this.lblCookieMakerStatus.InvokeRequired)
				{
				SetCookieMakerLabelCallback d = new SetCookieMakerLabelCallback(SetCookieMakerStatus);
				this.Invoke(d, new object[] { action, flavor });
				}
			else
				SetCookieMakerStatus( action, flavor );
			}

		private void SetCookieMakerStatus( string action, string flavor )
			{
			lblCookieMakerStatus.Text = string.Format(" {0} {1} Cookie!", action, flavor );
			switch ( action.ToLower() )
				{
				case "baking":
					lblCookieMakerStatus.BackColor = Color.Red;
					break;
				case "baked":
					lblCookieMakerStatus.BackColor = Color.White;
					break;
				}
			}

		// event callback for cookie monster actions
		delegate void SetCookieMonsterListCallback(CookieMonsterAction cookieMonsterAction);
		private void CookieMakerActionOccurred(CookieMonsterAction cookieMonsterAction)
			{
			// if sent from thread other than UI we must invoke
			if (this.lvCookieMonster.InvokeRequired)
				{
				SetCookieMonsterListCallback d = new SetCookieMonsterListCallback(SetCookieMMonsterList);
				this.Invoke(d, new object[] { cookieMonsterAction });
				}
			else
				SetCookieMMonsterList(cookieMonsterAction);
			}

		private void SetCookieMMonsterList(CookieMonsterAction cookieMonsterAction)
			{
			ListViewItem item = lvCookieMonster.Items.Insert(0, new ListViewItem( cookieMonsterAction.Time.ToString("hh:mm:ss")));
			item.SubItems.Add(cookieMonsterAction.Action.ToString());
			item.SubItems.Add(cookieMonsterAction.Cookie.Flavor);
			}

		#endregion callbacks for control displays

		}
	}
