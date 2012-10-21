using System;
using System.ComponentModel.Composition;
using System.Reflection;
using System.Windows.Forms;
using Oglr.Core;
using Oglr.Core.Behaviour;
using Oglr.Core.Controls;
using Oglr.InGame;
using Oglr.InGame.Interpolation;

namespace Oglr.Plugins
{
	[Export( typeof( IBehaviourPlugin ) )]
	public class FloatAnimationBehaviourPlugin : IBehaviourPlugin
	{
		public ImageProperties Icon
		{
			get
			{
				return Images.SummonImage(
					Assembly.GetExecutingAssembly( ), @"Oglr.Plugins.Resources.float_animation_behaviour_icon.png" ) ;
			}
		}

		public IHandleDragDrop CreateDragDropHandler(IEntityCreationProperties entityCreationProperties)
		{
			return new BehaviourDragDropHandler(buildBehaviour);
		}

		IBehaviour buildBehaviour(ITreeItem forEditor)
		{
			ItemProperties itemProperties = forEditor.ItemProperties ;

			var behaviour = new FloatAnimationBehaviour(
				itemProperties,
				new FloatAnimationBehaviourProperties
					{
						DurationInSeconds = .75f,
						Easing = Easing.EaseInOut,
						From = 0,
						To = 0,
						Name = @"float_animation_{0}".FormatWith( IoC.Model.NextItemNumber ),
						NameOfPropertyToModify = @"Foo",
						ClrTypeOfInterpolator = typeof( Quartic ).AssemblyQualifiedName
					} ) ;

			return behaviour ;
		}

		public string CategoryName
		{
			get
			{
				return @"Behaviour/Float animation" ;
			}
		}

		public Control ControlForAboutBox
		{
			get
			{
				return new PluginDescriptionControl( this ) ;
			}
		}

		public void InitialiseInUi( IMainForm mainForm )
		{
		}

		public string Name
		{
			get
			{
				return @"Float animation" ;
			}
		}
	}
}