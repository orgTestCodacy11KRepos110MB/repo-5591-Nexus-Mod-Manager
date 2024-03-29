﻿namespace Nexus.Client.Settings
{
    using Nexus.Client.ModManagement;
    using SevenZip;
    using System;

	/// <summary>
	/// The contracts for classes exposing user and application scoped settings.
	/// </summary>
	public interface ISettings
	{
        /// <summary>
		/// Gets the URL where the mod manager is available for download.
		/// </summary>
		/// <value>The URL where the mod manager is available for download.</value>
		string ModManagerUrl { get; }

		/// <summary>
		/// Gets the list of installed games.
		/// </summary>
		/// <value>The list of installed games.</value>
		SettingsList InstalledGames { get; }

		/// <summary>
		/// Gets whether the detection of installed games has taken place.
		/// </summary>
		/// <value>Whether the detection of installed games has taken place.</value>
		bool InstalledGamesDetected { get; set; }

		/// <summary>
		/// Gets or sets whether or not the client should manage the new Cache System.
		/// </summary>
		/// <value>The id of the remembered game mode.</value>
		bool CacheOverhaulSetup { get; set; }

		/// <summary>
		/// Gets or sets whether the selected game mode should be rememberd the next time the client is started.
		/// </summary>
		/// <value>Whether the selected game mode should be rememberd the next time the client is started.</value>
		bool RememberGameMode { get; set; }

		/// <summary>
		/// Gets or sets whether the manager supports the offline mode.
		/// </summary>
		/// <value>Whether the manager supports the offline mode.</value>
		bool SupportOfflineMode { get; set; }

		/// <summary>
		/// Gets or sets whether the manager should work in offline mode.
		/// </summary>
		/// <value>Whether the manager should work in offline mode.</value>
		bool OfflineMode { get; set; }

		/// <summary>
		/// Gets or sets the id of the remembered game mode.
		/// </summary>
		/// <value>The id of the remembered game mode.</value>
		string RememberedGameMode { get; set; }

		/// <summary>
		/// Gets or sets whether the selected view mode should be remembered the next time the client is started.
		/// </summary>
		/// <value>Whether the selected view mode should be remembered the next time the client is started.</value>
		bool UseCategoryView { get; set; }

		/// <summary>
		/// Gets or sets the category view default sorting column.
		/// </summary>
		/// <value>The category view default sorting column.</value>
		int CategoryViewDefaultSortColumn { get; set; }

		/// <summary>
		/// Gets or sets the category view default sort order.
		/// </summary>
		/// <value>The category view default sort order.</value>
		int CategoryViewDefaultSortOrder { get; set; }

		/// <summary>
		/// Gets or sets whether the side panel should be shown in the mod panel.
		/// </summary>
		/// <value>Whether the side panel should be shown in the mod panel.</value>
		bool ShowSidePanel { get; set; }

		/// <summary>
		/// Gets or sets whether to show a startup message.
		/// </summary>
		/// <value>Whether to show a startup message.</value>
		bool ShowStartupMessage { get; set; }

		/// <summary>
		/// Gets or sets whether to show a startup message.
		/// </summary>
		/// <value>Whether to show a startup message.</value>
		bool ShowAlphaDisclaimer { get; set; }

		/// <summary>
		/// Gets or sets whether to show a game specific disclaimer.
		/// </summary>
		/// <value>Whether to show a game specific disclaimer.</value>
		bool ShowFallout4UpgradeDisclaimer { get; set; }

		/// <summary>
		/// Gets or sets whether to show a game specific disclaimer.
		/// </summary>
		/// <value>Whether to show a game specific disclaimer.</value>
		bool ShowCP2077UpgradeDisclaimer { get; set; }

		/// <summary>
		/// Gets or sets whether the manager should prevent readme files from being installed.
		/// </summary>
		/// <value>Whether the manager should prevent readme files from being installed.</value>
		bool SkipReadmeFiles { get; set; }

		/// <summary>
		/// Gets or sets whether the manager should prevent the visualization of the Mod Warning Icon.
		/// </summary>
		/// <value>Whether the manager should prevent the visualization of the Mod Warning Icon.</value>
		bool HideModUpdateWarningIcon { get; set; }

		/// <summary>
		/// Gets or sets whether the category view should show or hide the empty categories.
		/// </summary>
		/// <value>Whether the category view should show or hide the empty categories.</value>
		bool ShowEmptyCategory { get; set; }

		/// <summary>
		/// Gets or sets whether the category view should expand all the categories when loaded.
		/// </summary>
		/// <value>Whether the category view should expand all the categories when loaded.</value>
		bool ShowExpandedCategories { get; set; }

		/// <summary>
		/// Gets the path of the folder where a game mode's virtual folder is stored.
		/// </summary>
		/// <remarks>
		/// The dictionary maps game mode ids to their corresponding install info folder paths.
		/// </remarks>
		/// <value>The path of the folder where a game mode's virtual folder is stored.</value>
		PerGameModeSettings<string> VirtualFolder { get; }

		/// <summary>
		/// Gets the path of the folder where a game mode's install info is stored.
		/// </summary>
		/// <remarks>
		/// The dictionary maps game mode ids to their corresponding HDLink folder paths.
		/// </remarks>
		/// <value>The path of the folder where a game mode's HDLink is stored.</value>
		PerGameModeSettings<string> HDLinkFolder { get; }

		/// <summary>
		/// Gets whether or not to use the multi hd install.
		/// </summary>
		/// <value>Whether or not to use the multi hd install.</value>
		PerGameModeSettings<bool> MultiHDInstall { get; }

		/// <summary>
		/// Gets or sets whether the manager should force the creation of hardlinks.
		/// </summary>
		/// <value>Whether the manager should force the creation of hardlinks.</value>
		bool ForceHardLinks { get; set; }

		/// <summary>
		/// Gets the installation path dictionary.
		/// </summary>
		/// <remarks>
		/// The dictionary maps game mode ids to their corresponding installation paths.
		/// </remarks>
		/// <value>The installation path dictionary.</value>
		PerGameModeSettings<string> InstallationPaths { get; }

		/// <summary>
		/// Gets the executable path dictionary.
		/// </summary>
		/// <remarks>
		/// The dictionary maps game mode ids to their corresponding executable paths.
		/// </remarks>
		/// <value>The installation path dictionary.</value>
		PerGameModeSettings<string> ExecutablePaths { get; }

		/// <summary>
		/// Gets the path of the folder where a game mode's mods are stored.
		/// </summary>
		/// <remarks>
		/// The dictionary maps game mode ids to their corresponding mod folder paths.
		/// </remarks>
		/// <value>The path of the folder where a game mode's mods are stored.</value>
		PerGameModeSettings<string> ModFolder { get; }

		/// <summary>
		/// Gets the path of the folder where a game's required tool is stored.
		/// </summary>
		/// <remarks>
		/// The dictionary maps game mode ids to their corresponding required tool folder paths.
		/// </remarks>
		/// <value>The path of the folder where a game's required tool is stored.</value>
		PerGameModeSettings<string> ToolFolder { get; }

		/// <summary>
		/// Gets the path of the folder where a game mode's install info is stored.
		/// </summary>
		/// <remarks>
		/// The dictionary maps game mode ids to their corresponding install info folder paths.
		/// </remarks>
		/// <value>The path of the folder where a game mode's install info is stored.</value>
		PerGameModeSettings<string> InstallInfoFolder { get; }

		/// <summary>
		/// Gets the path of the supported tools.
		/// </summary>
		/// <remarks>
		/// The dictionary maps game mode ids to their supported tools.
		/// </remarks>
		/// <value>The path of the folder where supported tools are installed.</value>
		PerGameModeSettings<KeyedSettings<string>> SupportedTools { get; }

		/// <summary>
		/// Gets the path of the folder where a game mode's TraceLog is stored.
		/// </summary>
		/// <remarks>
		/// The dictionary maps game mode ids to their corresponding install info folder paths.
		/// </remarks>
		/// <value>The path of the folder where a game mode's TraceLog is stored.</value>
		string TraceLogFolder { get; set; }

		/// <summary>
		/// Gets the path of the folder where a game mode's TraceLog is stored.
		/// </summary>
		/// <remarks>
		/// The dictionary maps game mode ids to their corresponding install info folder paths.
		/// </remarks>
		/// <value>The path of the folder where a game mode's TraceLog is stored.</value>
		string TempPathFolder { get; set; }

		/// <summary>
		/// Gets whether or not a game mode has completed it's first-time setup.
		/// </summary>
		/// <value>Whether or not a game mode has completed it's first-time setup.</value>
		PerGameModeSettings<bool> CompletedSetup { get; }

		/// <summary>
		/// Gets the dictionary of custom game-mode-specific settings.
		/// </summary>
		/// <value>The dictionary of custom game-mode-specific settings.</value>
		PerGameModeSettings<PerGameModeSettings<object>> CustomGameModeSettings { get; }

		/// <summary>
		/// Gets the application's saved window positions.
		/// </summary>
		/// <value>The application's saved window positions.</value>
		WindowPositions WindowPositions { get; }

		/// <summary>
		/// Gets the application's saved dock panel layouts.
		/// </summary>
		/// <value>The application's saved dock panel layouts.</value>
		KeyedSettings<string> DockPanelLayouts { get; }

		/// <summary>
		/// Gets the application's saved column widths.
		/// </summary>
		/// <value>The application's saved column widths.</value>
		ColumnWidths ColumnWidths { get; }

		/// <summary>
		/// Gets the application's saved splitter sizes.
		/// </summary>
		/// <value>The application's saved splitter sizes.</value>
		SplitterSizes SplitterSizes { get; }

		/// <summary>
		/// Gets or sets the preferred compression level to use for mods.
		/// </summary>
		/// <remarks>
		/// Note that not all mod formats support configurable compression levels.
		/// </remarks>
		/// <value>The preferred compression level to use for mods.</value>
		CompressionLevel ModCompressionLevel { get; set; }

		/// <summary>
		/// Gets or sets the preferred compression format to use for mods.
		/// </summary>
		/// <remarks>
		/// Note that not all mod formats support configurable compression formats.
		/// </remarks>
		/// <value>The preferred compression format to use for mods.</value>
		OutArchiveFormat ModCompressionFormat { get; set; }

		/// <summary>
		/// Gets the mods that have been queued to be added to the mod manager for given game modes.
		/// </summary>
		/// <value>The mods that have been queued to be added to the mod manager for given game modes.</value>
		PerGameModeSettings<KeyedSettings<AddModDescriptor>> QueuedModsToAdd { get; }

		/// <summary>
		/// Gets or sets the index of the currently selected Add Mod command in the Mod
		/// Manager view.
		/// </summary>
		/// <value>The index of the currently selected Add Mod command in the Mod
		/// Manager view.</value>
		int SelectedAddModCommandIndex { get; set; }

		/// <summary>
		/// Gets the last used launch command for a game mode.
		/// </summary>
		/// <value>The last used launch command for a game mode.</value>
		PerGameModeSettings<string> SelectedLaunchCommands { get; }

		/// <summary>
		/// Gets or sets whether or not the client should check for new versions of managed mods.
		/// </summary>
		/// <value>Whether or not the client should check for new versions of managed mods.</value>
		bool CheckForNewModVersions { get; set; }

		/// <summary>
		/// Gets or sets whether or not the client should override the Local Mod Name.
		/// </summary>
		/// <value>Whether or not the client should override the Local Mod Name.</value>
		bool OverrideLocalModNames { get; set; }
		
		/// <summary>
		/// Gets or sets the last time the program checked for mod updates.
		/// </summary>
		/// <value>The last time the program checked for mod updates.</value>
		string LastModVersionsCheckDate { get; set; }

		/// <summary>
		/// Gets or sets the last time the program checked for missing download IDs.
		/// </summary>
		/// <value>The last time the program checked for missing download IDs.</value>
		DateTime LastCheckedMissingDownloadID { get; set; }

		/// <summary>
		/// Gets or sets the interval (in days) to wait before checking for mod updates.
		/// </summary>
		/// <value>The interval (in days) to wait before checking for a mod updates.</value>
		int ModVersionsCheckInterval { get; set; }

		/// <summary>
		/// Gets or sets the Max current downloads limit.
		/// </summary>
		/// <value>The max current downloads limit.</value>
		int MaxConcurrentDownloads { get; set; }

		/// <summary>
		/// Gets or sets whether the client should add missing info to managed mods.
		/// </summary>
		/// <value>Whether the client should add missing info to managed mods.</value>
		bool AddMissingInfoToMods { get; set; }

		/// <summary>
		/// Gets the custom launch command for a game mode.
		/// </summary>
		/// <remarks>
		/// The dictionary maps game mode ids to their corresponding custom launch commands.
		/// </remarks>
		/// <value>The custom launch command for a game mode.</value>
		PerGameModeSettings<string> CustomLaunchCommands { get; }

		/// <summary>
		/// Gets the custom launch command arguments for a game mode.
		/// </summary>
		/// <remarks>
		/// The dictionary maps game mode ids to their corresponding custom launch command argumentss.
		/// </remarks>
		/// <value>The custom launch command arguments for a game mode.</value>
		PerGameModeSettings<string> CustomLaunchCommandArguments { get; }

		/// <summary>
		/// Gets the links to help resources.
		/// </summary>
		/// <value>The links to help resources.</value>
		KeyedSettings<string> HelpLinks { get; }

        /// <summary>
        /// Gets which extensions shall have shell extensions added.
        /// </summary>
        KeyedSettings<bool> AddShellExtensions { get; }

        /// <summary>
        /// Gets or sets whether NMM should be associated with NXM url's.
        /// </summary>
        bool AssociateWithUrl { get; set; }

		/// <summary>
		/// Gets or sets whether to check for updates on startup.
		/// </summary>
		/// <value>Whether to check for updates on startup.</value>
		bool CheckForUpdatesOnStartup { get; set; }

		/// <summary>
        /// Gets or sets whether to check for tips on startup.
        /// </summary>
        /// <value>Whether to check for updates on startup.</value>
        bool CheckForTipsOnStartup { get; set; }

		/// <summary>
		/// Gets or sets the last time the program checked for an update.
		/// </summary>
		/// <value>The last time the program checked for an update.</value>
		string LastUpdateCheckDate { get; set; }

		/// <summary>
		/// Gets or sets the interval (in days) to wait before checking for a program update.
		/// </summary>
		/// <value>The interval (in days) to wait before checking for a program update.</value>
		int UpdateCheckInterval { get; set; }

		/// <summary>
		/// Gets or sets whether to scan sub directories of the mod directory for mods.
		/// </summary>
		/// <value>Whether to scan sub directories of the mod directory for mods.</value>
		bool ScanSubfoldersForMods { get; set; }

		/// <summary>
		/// Gets the setting values that should not be applied until the next application restart.
		/// </summary>
		/// <value>The setting values that should not be applied until the next application restart.</value>
		PerGameModeSettings<KeyedSettings<string>> DelayedSettings { get; }

		/// <summary>
		/// Gets or sets whether the mod manager should be closed after a game is launched.
		/// </summary>
		/// <value>Whether the mod manager should be closed after a game is launched.</value>
		bool CloseModManagerAfterGameLaunch { get; set; }

		/// <summary>
		/// Gets or sets whether the setting indicating whether the mod manager should be closed after a game is launched is remembered.
		/// </summary>
		/// <value>Whether the setting indicating whether the mod manager should be closed after a game is launched is remembered.</value>
		bool CloseModManagerAfterGameLaunchIsRemembered { get; set; }

		/// <summary>
		/// Gets or sets whether to use multithreaded downloads.
		/// </summary>
		/// <value>Whether to use multithreaded downloads.</value>
		bool UseMultithreadedDownloads { get; set; }

		/// <summary>
		/// Gets or sets whether the Skyrim SE warning has already been shown.
		/// </summary>
		/// <value>Whether the Skyrim SE warning has already been shown.</value>
		bool SkyrimSEFirstInstallWarning { get; set; }

		/// <summary>
		/// Saves changes to the user settings.
		/// </summary>
		void Save();

		/// <summary>
		/// Reloads the stored values from persistent storage, discarding any unsaved changes.
		/// </summary>
		void Reload();

        /// <summary>
        /// The API key used to authenticate user against Nexus Mods API.
        /// </summary>
        string ApiKey { get; set; }

		/// <summary>
		/// This setting is a workaround to allow users to download SkyrimSE nxm links from within the desired game mode
		/// Either SkyrimSE or SkyrimGOG.
		/// </summary>
		string SkyrimSEDownloadOverride { get; set; }
	}
}
