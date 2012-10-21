using System;

namespace Oglr.Core
{
	public enum UserActionInEditor
	{
		Idle,
		RunningBehaviour,
		AddingAnItem, 
		MovingTheCamera,   
		MovingItems,         
		CopyingItems,         
		RotatingItems,       
		ScalingItems,        
		CreatingSelectionBoxByDragging,      
	}
}