using System;
using System.ComponentModel.Composition;
using Microsoft.Xna.Framework;
using Oglr.Core;

namespace Oglr.Plugins
{
	[Export(typeof(IShapeProvider))]
	public class CapsuleShapeProvider : IShapeProvider
	{
		class CapsuleShapeProperties
		{
			internal CapsuleShapeProperties()
			{
				Height = 250 ;
				EndRadius = 25 ;
				NumberOfEdges = 4 ;
			}

			public float Height
			{
				get;
				private set ;
			}

			public float EndRadius
			{
				get;
				private set ;
			}

			public int NumberOfEdges
			{
				get;
				private set ;
			}
		}

		readonly CapsuleShapeProperties _properties = new CapsuleShapeProperties(  );
		
		public Vector2[ ] Vertices
		{
			get
			{
				Vertices vertices = Oglr.Core.Vertices.CreateCapsule( 
					_properties.Height, 
					_properties.EndRadius, 
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
				return @"Capsule" ;
			}
		}
	}
}