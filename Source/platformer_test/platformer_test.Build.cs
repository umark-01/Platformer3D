// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class platformer_test : ModuleRules
{
	public platformer_test(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
