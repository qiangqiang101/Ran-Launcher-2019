# Ran Launcher 2019

Windows game launcher and patch-management tools for a Ran Online-style game server, written in Visual Basic .NET.

## Projects

- **Ran Launcher 2019** - Main WinForms launcher. Displays the launch interface, manages updates, opens news and website pages, and starts the game executable.
- **PatchMaker** - WinForms utility for preparing patch content.
- **DummyGame** - Minimal test game executable used to exercise launcher behavior.

## Requirements

- Windows
- Visual Studio 2015 or newer with the .NET desktop development workload
- .NET Framework 4.5.2

The solution targets **Any CPU** by default. The launcher also has x86 build configurations.

## Build

1. Open `Ran Launcher 2019.sln` in Visual Studio.
2. Restore or select the target framework if prompted.
3. Build the solution with **Build > Build Solution**.

The executable and supporting files are written to each project's `bin\<Configuration>` directory.

To build from a Developer Command Prompt:

```bat
msbuild "Ran Launcher 2019.sln" /p:Configuration=Release
```

## Configuration

The launcher reads runtime configuration and language files from:

```text
<launcher-directory>\Data\Launcher\config.xml
<launcher-directory>\Data\Launcher\language.xml
```

Additional launcher assets, including HTML, images, video, and audio, are also loaded from the `Data\Launcher` directory. `config.xml` contains server links, the game executable name and arguments, patch address, server version, display mode, and fullscreen settings.

Keep runtime configuration and assets outside source control when they contain server-specific or deployment-specific values.

## Usage

### Launcher

Run `Launcher.exe` from the launcher project's output directory. The launch UI loads the configured server name and reads local or remote intro content according to `DisplayMethod`.

The Play action opens the update window and starts the configured game executable after update checks complete.

### Patch Maker

Run `PatchMaker.exe`, select an input directory and output directory, and start the patch task.

### Dummy Game

Run `DummyGame.exe` or `Game.exe` as the test game executable. It can be used to verify launcher-to-game process integration.

## License

This project is licensed under the [MIT License](LICENSE).
