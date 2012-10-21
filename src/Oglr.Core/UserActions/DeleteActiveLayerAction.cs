using System;

namespace Oglr.Core.UserActions
{
	public class DeleteActiveLayerAction : IUserAction
	{
		public DeleteActiveLayerAction( )
		{
		}

		public void Process( )
		{
			IModel model1 = IoC.Model ;
			model1.DeleteLayer( model1.ActiveLayer ) ;
		}
	}
}