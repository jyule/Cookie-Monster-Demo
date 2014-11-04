/**
 * CookieJar
 * Interface and base class for CookieJar objects
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CookieMonster
	{
	/// <summary>
	/// CookieJar Interface - all cookie jars must implement
	/// </summary>
	public interface ICookieJar
		{
		string Name { get; }
		int GetCookieCount();
		void AddCookie(ICookie cookie);
		ICookie TakeCookie();
		}

	/// <summary>
	/// Base default CookieJar class
	/// </summary>
	public class CookieJar : ICookieJar
		{
		#region Global variable
		private List<ICookie> g_Cookies;
		#endregion Global variable

		#region Properties
		//----------------------
		private string m_sName = "";
		public string Name
			{
			get { return (m_sName); }
			}
		#endregion Properties

		#region Constructor/Destructor
		//----------------------
		public CookieJar()
			{
			g_Cookies = new List<ICookie>();
			}
		#endregion Constructor/Destructor

		#region Public methods
		//----------------------
		/// <summary>
		/// Gets the current numbe rof cookies in the jar.
		/// </summary>
		/// <returns></returns>
		public virtual int GetCookieCount()
			{
			// thread safe
			lock (g_Cookies)
				{
				return (g_Cookies.Count);
				}
			}

		//----------------------
		/// <summary>
		/// Adds a cookie to the top of the jar/list asynchronously
		/// </summary>
		/// <param name="cookie"></param>
		public virtual void AddCookie(ICookie cookie)
			{
			// add cookie on new thread
			Thread thread = new Thread(() => PutCookie( cookie ));
			thread.Start();
			}

		//----------------------
		/// <summary>
		/// Gives a cookie from the top of the jar (bottom of list)
		/// </summary>
		/// <returns></returns>
		public virtual ICookie TakeCookie()
			{
			// let exceptions bubble up to caller
			return ( GetCookie() );
			}
		#endregion Public methods


		#region Private methods
		//----------------------
		/// <summary>
		/// Worker to remove a cookie from the jar/list
		/// </summary>
		/// <returns></returns>
		private ICookie GetCookie()
			{
			// thread safety
			lock (g_Cookies)
				{
				if (g_Cookies.Count > 0)
					{
					// take cookie from top of jar/list (LIFO)
					ICookie cookie = g_Cookies[0];
					g_Cookies.Remove(cookie);

					// let owner know a cookie was taken
					OnCookieTaken();

					return (cookie);
					}
				throw new Exception("Out of Cookies!");
				}
			}

		//----------------------
		/// <summary>
		/// Worker to handle adding a cookie to the jar/list
		/// </summary>
		/// <param name="cookie"></param>
		private void PutCookie(ICookie cookie)
			{
			// top of list is top of jar (LIFO)
			// thread safety
			lock (g_Cookies)
				{
				g_Cookies.Insert( 0, cookie );
				}
			OnCookieAdded( cookie );
			}
		#endregion Private methods

		#region Event handlers
		public delegate void CookieAddedHandler(ICookie cookie);
		public delegate void CookieTakenHandler();
		public event CookieAddedHandler CookieAdded;
		public event CookieTakenHandler CookieTaken;
		//----------------------
		protected virtual void OnCookieAdded(ICookie cookie)
			{
			if ( CookieAdded != null )
				CookieAdded(cookie );
			}
		//----------------------
		protected virtual void OnCookieTaken()
			{
			if (CookieTaken != null)
				CookieTaken();
			}
		#endregion Event handlers
		}
	}
