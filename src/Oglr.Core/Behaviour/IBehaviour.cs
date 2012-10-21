using System;
using Oglr.InGame;

namespace Oglr.Core.Behaviour
{
	public interface IBehaviour : ITreeItem
	{
		void Start( ) ;
		void Stop( ) ;

		BehaviourProperties BehaviourProperties 
		{
			get ;
		}
	}
}