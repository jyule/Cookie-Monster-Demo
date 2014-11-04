/**
 * CookieMaker
 * Interface and base class for CookieMaker objects
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CookieMonster
	{
	/// <summary>
	/// CookieMaker Interface - all cookie makeras must implement
	/// </summary>
	public interface iCookieMaker
		{
		//List<string> LoadCookieFlavors();
		ICookie BakeCookie();
		ICookie BakeCookie( string cookieFlavor );
		string[] GetAvailableCookieFlavors();
		}
	
	// basic default cookie maker
	/// <summary>
	/// Base default CookieMaker class
	/// </summary>
	public class CookieMaker : iCookieMaker
		{
		#region globals variables
		Random g_Randomizor = new Random(DateTime.Now.Millisecond);
		List<string> g_CookieFlavors;
		#endregion global variables

		#region Properties
		//--------------------
		private string m_sName;
		public virtual string Name
			{
			// read only
			get { return (m_sName); }
			}
		#endregion Properties

		#region Constructors/Destructor
		//--------------------
		/// <summary>
		/// Generic initilization
		/// </summary>
		/// <param name="name"></param>
		public CookieMaker(string name )
			{
			m_sName = name;
			// load available pre-configured cookie flavors
			g_CookieFlavors = LoadCookieFlavors();
			}

		//--------------------
		/// <summary>
		/// Initializes CookieMaker and bakes designated number of cookies and puts them in designated CookieJar
		/// </summary>
		/// <param name="name"></param>
		/// <param name="bakeCookies"></param>
		/// <param name="cookieJar"></param>
		public CookieMaker(string name, int bakeCookies, ICookieJar cookieJar)
			{
			m_sName = name;
			// load available pre-configured cookie flavors
			g_CookieFlavors = LoadCookieFlavors();

			// bake some cookies
			for ( int i=0; i<bakeCookies; i++ )
				cookieJar.AddCookie( BakeCookie() );
			}
		#endregion Constructors/Destructor

		#region public methods
		//--------------------
		/// <summary>
		/// Bakes a random flavored cookie
		/// </summary>
		/// <returns></returns>
		public ICookie BakeCookie()
			{
			return (BakeCookie( "" ) );
			}

		//--------------------
		/// <summary>
		/// Bakes a specifically flavored cookie, or random if no valid flavor passed
		/// </summary>
		/// <param name="cookieFlavor"></param>
		/// <returns></returns>
		public virtual ICookie BakeCookie(string cookieFlavor)
			{
			// let caller know that a cookie is being baked
			OnCookieBaking("Baking", cookieFlavor);
			
			// verify valid flavor was passed
			string bakeFlavor = "";
			foreach (string flavor in g_CookieFlavors)
				{
				if ( string.Compare( flavor, cookieFlavor, true) == 0 )
					{
					bakeFlavor = flavor;
					break;
					}
				}
			if ( bakeFlavor.Length == 0 )
				bakeFlavor = g_CookieFlavors[g_Randomizor.Next(g_CookieFlavors.Count)];

			// bake cookie
			Cookie cookie = new Cookie(bakeFlavor);

			// let caller know that a cookie has been baked
			OnCookieBaking("Baked", bakeFlavor);
			return ( (ICookie)cookie );
			}

		//--------------------
		/// <summary>
		/// Gets a string array of the available flavors.
		/// </summary>
		/// <returns></returns>
		public virtual string[] GetAvailableCookieFlavors()
			{
			// deep copy
			string[] flavors = new string[g_CookieFlavors.Count];
			g_CookieFlavors.CopyTo(flavors);
			return (flavors);
			}
		#endregion public methods

		#region Private/Protected methods
		//--------------------
		/// <summary>
		/// Loads available cookie types/flavors into memory
		/// </summary>
		/// <returns></returns>
		protected virtual List<string> LoadCookieFlavors()
			{
			// We could load from an external data source such as an XML file or SQL table
			// For simplicity and self-conatinment for this demo we will just hard code some flavors here..
			// We could/should also expand the flavors to be 'CookieTypes' which list ingredients, bake times etc.
			try
				{
				List<string> cookieFlavors = new List<string>();
				cookieFlavors.AddRange( new string[]	{
														"Sugar",
														"Chocolate Chip",
														"Oatmeal Rasin",
														"Snicker Doodle",
														"Lady Finger",
														"Peanut Butter",  // yuck!
														"Macaroon"
														} );
				return(cookieFlavors);
				}
			catch(Exception ex1)
				{
				// handle Exception
				throw ex1;
				}
			finally
				{
				// if we were loading from an external source we would cleanup here
				}
			}
		#endregion Private methods

		// event handlers
		public delegate void CookieBakingHandler(string action, string flavor);
		public event CookieBakingHandler CookieBaking;
		protected virtual void OnCookieBaking(string action, string flavor)
			{
			if ( CookieBaking != null )
				CookieBaking( action, flavor );
			}
		}
	}
