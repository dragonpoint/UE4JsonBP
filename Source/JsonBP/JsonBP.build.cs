// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class JsonBP : ModuleRules
{
	public JsonBP(ReadOnlyTargetRules Target) : base(Target)
	{
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        //bUseUnityBuild  = false;
        PrecompileForTargets = PrecompileTargetsType.Any;

        PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
            });
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			});
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
                "Engine",
                "Json",
                "JsonUtilities",
				// ... add private dependencies that you statically link with here ...	
			});
    }
}
