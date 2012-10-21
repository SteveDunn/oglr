using System;
using System.Windows.Forms;
using Oglr.Core.Forms;
using Oglr.InGame;

namespace Oglr.Core.UserActions
{
	public class AddCustomPropertyAction : IUserAction
	{
		readonly ITreeItem _treeItem ;

		public AddCustomPropertyAction(ITreeItem treeItem )
		{
			_treeItem = treeItem ;
		}

		public void Process( )
		{
			CustomProperties customProperties = _treeItem.ItemProperties.CustomProperties ;

			var form = new AddCustomPropertyForm( e=> !customProperties.ContainsKey(e) ) ;

			DialogResult result = form.ShowDialog( ) ;

			if( result == DialogResult.OK )
			{
				IoC.Model.AddCustomProperty( _treeItem, form.NewCustomProperty ) ;
			}
		}
	}
}