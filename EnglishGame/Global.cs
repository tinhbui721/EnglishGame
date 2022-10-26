
using WMPLib;

static class Global
{

    public static bool SoundCheck = true;

    public static void correctSound()
    {
        if (SoundCheck)
        {
            WindowsMediaPlayer correct = new WindowsMediaPlayer();
            correct.URL = "correct.mp3";
        }
    }

    public static void wrongSound()
    {
        if (SoundCheck)
        {
            WindowsMediaPlayer wrong = new WindowsMediaPlayer();
            wrong.URL = "wrong.mp3";
            wrong.settings.volume = 50;
        }
    }


}