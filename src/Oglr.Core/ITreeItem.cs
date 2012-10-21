using System;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Oglr.Core.Behaviour;
using Oglr.InGame;

namespace Oglr.Core
{
	public interface ITreeItem
	{
		void Update( GameTime gameTime ) ;

		string Name
		{
			get ;
		}

		ICustomTypeDescriptor ObjectForPropertyGrid
		{
			get ;
		}

		ItemProperties ItemProperties
		{
			get;
		}

		BehaviourCollection Behaviours
		{
			get ;
		}

		void RenameTo( string name ) ;
		void AddBehaviour(IBehaviour behaviour) ;
		void PropertiesChanged(PropertyValueChangedEventArgs whatChanged);
	}
}