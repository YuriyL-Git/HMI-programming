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
	
	public class Property
	{
		public Property()
		{
		}
		
		private string _connectionType;
		[CategoryAttribute("ConnectionType"), DescriptionAttribute("COM or USB")]  
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
