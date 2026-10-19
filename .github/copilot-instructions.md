# GitHub Copilot Instructions for RimWorld Modding Project: Squad UI Tweaks (Continued)

## Mod Overview and Purpose
The "Squad UI Tweaks (Continued)" mod is an extension of the original work by drumad, now maintained with ongoing updates. This mod aims to enhance the user experience in RimWorld by providing several intuitive tweaks to the UI when managing groups of pawns. These improvements facilitate better control during combat, particularly when utilizing squads of characters in strategic operations.

## Key Features and Systems
- **Weapon Range Display**: When hovering the mouse over the "Attack" button, the mod displays the range of the currently equipped weapon, allowing players to make more informed tactical decisions.
- **Weapon Type Indicators**: The types of weapons each character carries are shown in the UI. Clicking on a weapon enables the player to assign targets to all pawns armed with that specific weapon, streamlining combat actions.
- **Seamless Integration**: Most of the implemented features leverage existing RimWorld functionality, with added links to enrich the interface.

## Coding Patterns and Conventions
- **Maintain Vanilla Structure**: The code structure mimics the vanilla game's organization, allowing for easier updates and maintenance.
- **Descriptive Naming**: Function and variable names should accurately describe their purpose or function. This improves readability and maintainability.
- **Consistent Spacing**: Code should adhere to a consistent indentation style, typically 4 spaces per indent level, to enhance readability.

## XML Integration
- The XML file (`About.xml`) is used to define the mod's metadata, such as the name, author, and package ID, following RimWorld's requirements for mod identification. Regularly update this file when making significant changes that alter the mod's description or compatible game versions.

## Harmony Patching
- **Harmony Library**: This mod is powered by Harmony, a widely-used library for patching methods during runtime. This enables modifications to existing game functionality without altering the core source code.
- **Patch Methods**: The mod's key functionalities rely on postfix patches, allowing the injection of additional behaviors after the original method executions. Examples include `CanShowEquipmentGizmos_postfix` and `GetSquadAttackGizmo_Postfix` located in `HarmonyPatches.cs`.

## Suggestions for Copilot
- **Code Completion**: Use Copilot to autocomplete methods and syntax according to RimWorld's development patterns, enhancing code efficiency and accuracy.
- **Refactoring Assistance**: Leverage Copilot's capabilities to suggest refactorings, particularly for repeated patterns or performance tuning.
- **Integration Testing**: Prompt Copilot to generate unit tests where applicable, especially when creating new functions or modifying existing patches.
- **Documentation Enhancement**: Encourage Copilot to aid in generating or updating comments within the C# files, ensuring they effectively outline the logic and flow of the code.

By adhering to these guidelines and leveraging GitHub Copilot as a development tool, mod contributors can efficiently enhance and maintain the Squad UI Tweaks mod for ongoing gameplay improvements.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

