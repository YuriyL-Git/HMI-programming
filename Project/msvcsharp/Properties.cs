/*
 * Created by SharpDevelop.
 * User: User
 * Date: 22.01.2021
 * Time: 15:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel; 

namespace msvcsharp
{
	/// <summary>
	/// Description of Properties.
	/// </summary>
	/// 
	
	public class Properties
	{
		public Properties()
		{
		}
		
		private string _connectionType;
		[CategoryAttribute("ID Settings"), DescriptionAttribute("Name of the customer")]  
        public string ConnectionType {  
        get
        {
            return _connectionType;  
        }  
        set
        {
            _connectionType = value;  
        }  
    }  
	}
}
