public static class ProfileStatic
{
    private static string _profilePath = "Assets/Resource/Profile/";
    private static string _profileName;
    private static string _profileFolderPath;
    /// <summary>
    /// Get access to ProfilePath private variable
    /// </summary>
    public static string ProfilePath { get => _profilePath;}
    /// <summary>
    /// Get access to ProfileName private variable
    /// </summary>
    public static string ProfileName 
    { 
        get => _profileName; 
        set
        {
            _profileName = value;
        }
    }
    /// <summary>
    /// Get access to ProfileFolderPath private variable
    /// </summary>
    public static string ProfileFolderPath { 
        get => _profileFolderPath; 
        set
        {
            _profileFolderPath = value;
        }
    }
}
