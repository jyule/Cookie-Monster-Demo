/**
 * CookieMonster
 * Interface and base class for CookieMonster objects
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookieMonster
	{

	/// <summary>
	/// Enum for actions allowed by CookieMonster.
	/// Better implementation would allow for unlimited/unforseen actions (in a hurry)
	/// </summary>
	public enum CookieAction
		{
		Eat,
		PutBack,
		ThrowAway,
		}

	#region Interface
	/// <summary>
	/// All Cookie Monsters will implement
	/// </summary>
	public interface ICookieMonster
		{
		string Name {  get; }
		void TakeCookie( CookieAction cookieAction, ICookieJar cookieJar );
		List<CookieMonsterAction> GetActionHistory();
		}
	#endregion Interface

	#region Base Class
	// Base default Cookie Monster
	public class CookieMonster : ICookieMonster
		{
		#region Global variables
		private List<CookieMonsterAction> g_ActionHistory;
		#endregion Global variables

		#region Properties
		private string m_sName;
		public string Name
			{
			get {  return( m_sName ); }
			}
		#endregion Properties

		#region Constructors/Destructors
		//--------------------
		public CookieMonster(string name)
			{
			// init class
			m_sName = name;
			g_ActionHistory = new List<CookieMonsterAction>();
			}
		#endregion Constructors/Destructors

		#region Public Methods
		//--------------------
		/// <summary>
		/// CookieMonster takes a cookie from the specified CookieJar, and does the specified action
		/// </summary>
		/// <param name="cookieAction"></param>
		/// <param name="cookieJar"></param>
		public virtual void TakeCookie(CookieAction cookieAction, ICookieJar cookieJar)
			{
			// cheating here - cookieJar should probably be a service address

			// let exceptions bubble up to caller
			Cookie cookie = (Cookie)cookieJar.TakeCookie();
			switch( cookieAction )
				{
				case CookieAction.Eat:
					// action is virtual
					break;
				case CookieAction.PutBack:
					cookieJar.AddCookie( (ICookie)cookie );
					break;
				case CookieAction.ThrowAway:
					// action is virtual
					break;
				}

			CookieMonsterAction action = new CookieMonsterAction( cookie, cookieAction );
			g_ActionHistory.Add( action );
			OnCookieMonsterAction( action );
			}

		//--------------------
		/// <summary>
		/// Gets a deep copy of the action history.
		/// </summary>
		/// <returns></returns>
		public virtual List<CookieMonsterAction> GetActionHistory()
			{
			// thread safe
			lock (g_ActionHistory)
				{
				// deep copy
				return (new List<CookieMonsterAction>(g_ActionHistory));
				}
			}
		#endregion Public Methods


		#region Event handlers
		public delegate void CookieMonsterActionHandler(CookieMonsterAction cookieMonsterAction);
		public event CookieMonsterActionHandler CookieMonsterAction;
		//--------------------
		protected virtual void OnCookieMonsterAction(CookieMonsterAction cookieMonsterAction)
			{
			if (CookieMonsterAction != null)
				CookieMonsterAction(cookieMonsterAction);
			}
		#endregion Event handlers
		}
	#endregion Base Class
	}
