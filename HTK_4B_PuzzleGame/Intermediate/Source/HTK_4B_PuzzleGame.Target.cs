using UnrealBuildTool;

public class HTK_4B_PuzzleGameTarget : TargetRules
{
	public HTK_4B_PuzzleGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("HTK_4B_PuzzleGame");
	}
}
