// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class VivoxCore : ModuleRules
{
	public VivoxCore(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				string.Format("{0}/Public", ModuleDirectory),
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				string.Format("{0}/Private", ModuleDirectory),
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"VivoxCoreLibrary",
				"Projects",
				"Engine",
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
		
		if (Target.Platform == UnrealTargetPlatform.Win64)
		{
			string vivoxSdkDll = string.Format("{0}\\..\\ThirdParty\\VivoxCoreLibrary\\Windows\\Release\\x64\\vivoxsdk.dll", ModuleDirectory);
			if (!System.IO.File.Exists(vivoxSdkDll))
			{
				System.Diagnostics.Debug.WriteLine(string.Format("Warning: {0} does not exist", vivoxSdkDll));
			}
			RuntimeDependencies.Add(vivoxSdkDll);
		}
	}
}
