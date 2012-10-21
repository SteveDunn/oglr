using System;
using System.ComponentModel.Composition;
using System.Reflection;
using System.Windows.Forms;
using Oglr.Core;
using Oglr.Core.Controls;

namespace Oglr.Plugins.Krypton
{
	[Export(typeof(IEditorPlugin))]
	public class LightEditorPlugin : IEditorPlugin
	{
		public LightEditorPlugin( )
		{
		}

		public Control ControlForAboutBox
		{
			get
			{
				return new PluginDescriptionControl( this ) ;
			}
		}

		public Type EditorType
		{
			get
			{
				return typeof( LightEditor ) ;
			}
		}

		public string CategoryName
		{
			get
			{
				return @"Lighting/Krypton" ;
			}
		}

		public void InitialiseInUi( IMainForm mainForm )
		{
			ICategoryTabPage tab = mainForm.TryGetTabForCategory( CategoryName ) ;
			
			if( tab==null )
			{
				tab= buildTab( ) ;
				
				mainForm.AddCategoryTab( tab ) ;
			}

			tab.AddPlugin( this ) ;
		}

		ICategoryTabPage buildTab( )
		{
			var tabPage = new DefaultCategoryTabPage
				{
					CategoryName = CategoryName
				} ;
			
			return tabPage ;
		}

		public string Name
		{
			get
			{
				return @"Light" ;
			}
		}


		public ImageProperties ToolboxImage
		{
			get
			{
				return Images.SummonImage( Assembly.GetExecutingAssembly(  ), @"Oglr.Plugins.Krypton.Resources.light.png" ) ;
			}
		}

		public ImageProperties Icon
		{
			get
			{
				return Images.SummonImage( Assembly.GetExecutingAssembly(  ), @"Oglr.Plugins.Krypton.Resources.light.png" ) ;
			}
		}

		public IHandleDragDrop CreateDragDropHandler(IEntityCreationProperties entityCreationProperties)
		{
			throw new NotImplementedException();
		}
	}
}