/**
 * Cookie Interface and Base class
 * Represents a single cookie
 * Improvments: add unique ID, ingredients, 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookieMonster
	{
	#region Cookie Interface
	/// <summary>
	/// All cookies will implement
	/// </summary>
	public interface ICookie
		{
		string Flavor { get; }
		DateTime BakeTime { get; }
		}
	#endregion Cookie Interface

	// basic default cookie
	/// <summary>
	/// Base Cookie class
	/// </summary>
	public class Cookie : ICookie
		{
		#region Base Properties
		//--------------------
		//--------------------
		private string m_sFlavor;
		public virtual string Flavor
			{
			// read only
			get { return(m_sFlavor); }
			}
		//--------------------
		private DateTime m_dteBakeTime;
		public virtual DateTime BakeTime
			{
			// read only
			get { return (m_dteBakeTime); }
			}
		#endregion Base Properties

		#region Constructor/Destructors
		//--------------------
		public Cookie(string flavor)
			{
			m_sFlavor = flavor;
			m_dteBakeTime = DateTime.Now;
			}
		#endregion Constructor/Destructors
		}
	}
