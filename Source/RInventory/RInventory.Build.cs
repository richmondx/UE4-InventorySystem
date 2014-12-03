// Copyright 1998-2014 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RInventory : ModuleRules
{
	public RInventory(TargetInfo Target)
	{
		PublicDependencyModuleNames.AddRange(new string[] { 
            "Core", 
            "CoreUObject", 
            "Engine", 
            "InputCore", 
            "UMG", 
            "Slate", 
            "SlateCore" });
	}
}
