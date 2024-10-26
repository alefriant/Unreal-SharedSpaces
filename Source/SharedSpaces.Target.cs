// Copyright (c) Meta Platforms, Inc. and its affiliates.
// Use of the material below is subject to the terms of the MIT License
// https://github.com/oculus-samples/Unreal-SharedSpaces/blob/main/Source/LICENSE

using UnrealBuildTool;
using System.Collections.Generic;

public class SharedSpacesTarget : TargetRules
{
	public SharedSpacesTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        bValidateFormatStrings = false;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.Add("SharedSpaces");
	}
}
