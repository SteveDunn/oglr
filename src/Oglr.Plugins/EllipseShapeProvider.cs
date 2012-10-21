using System;
using System.ComponentModel.Composition;
using Microsoft.Xna.Framework;
using Oglr.Core;

namespace Oglr.Plugins
{
	[Export(typeof(IShapeProvider))]
	public class EllipseShapeProvider : IShapeProvider
	{
		class EllipseShapeProperties
		{
			internal EllipseShapeProperties( )
			{

				XRadius = 250 ;
				YRadius = 150 ;
				NumberOfEdges = 15 ;
			}

			public float XRadius
			{
				get;
				set ;
			}

			public float YRadius
			{
				get;
				set ;
			}

			public int NumberOfEdges
			{
				get;
				set ;
			}
		}

		readonly EllipseShapeProperties _properties = new EllipseShapeProperties(  );
		
		public Vector2[ ] Vertices
		{
			get
			{
				Vertices vertices = Oglr.Core.Vertices.CreateEllipse( 
					_properties.XRadius, 
					_properties.YRadius, 
					_properties.NumberOfEdges ) ;
				
				return vertices.ToArray(  ) ;
			}
		}

		public object Variables
		{
			get
			{
				return _properties ;
			}
		}

		public string Name
		{
			get
			{
				return @"Ellipse" ;
			}
		}
	}
}