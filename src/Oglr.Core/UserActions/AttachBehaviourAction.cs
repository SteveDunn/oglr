using System;
using System.Windows.Forms;
using Oglr.Core.Behaviour;
using Oglr.Core.Forms;
using Oglr.InGame;

namespace Oglr.Core.UserActions
{
	public class AttachBehaviourAction : IUserAction
	{
		readonly IBehaviour _behaviour ;
		readonly ITreeItem _treeItem ;

		public AttachBehaviourAction(IBehaviour behaviour, ITreeItem target )
		{
			_behaviour = behaviour ;
			_treeItem = target ;
		}

		public void Process( )
		{
			_treeItem.AddBehaviour( _behaviour );
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