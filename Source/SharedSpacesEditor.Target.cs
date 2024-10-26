// Copyright (c) Meta Platforms, Inc. and its affiliates.
// Use of the material below is subject to the terms of the MIT License
// https://github.com/oculus-samples/Unreal-SharedSpaces/blob/main/Source/LICENSE

using UnrealBuildTool;
using System.Collections.Generic;

public class SharedSpacesEditorTarget : TargetRules
{
	public SharedSpacesEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        bValidateFormatStrings = false;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.Add("SharedSpaces");
	}
}
