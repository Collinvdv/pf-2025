using System.Diagnostics;

namespace MyAppNamespace;

internal class Profile
{
    // properties 
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public Gender PrefGender { get; set; }
    public List<Like> AllLikes { get; set; } = new List<Like>();

    public List<Profile> SkippedProfiles { get; set; } = new List<Profile>();

    public List<Profile> LikedProfiles { get; set; } = new List<Profile>();

    public List<Profile> MatchProfiles { get; set; } = new List<Profile>();

    // constructor
    public Profile(string _name, Gender _gender, Gender _prefgender)
    {
        this.Name = _name;
        this.Gender = _gender;
        this.PrefGender = _prefgender;
    }

    // methods
    public void Like(Profile _receiver, Boolean _isliked)
    {
        // Add likes to have a trackrecord
        Like l = new Like(_receiver, this, _isliked);
        this.AllLikes.Add(l);

        // When it is liked push to correct list
        if (_isliked)
        {
            this.LikedProfiles.Add(_receiver);

            // Check if there is a match 
            if (_receiver.ProfileInLikes(this))
            {
                this.MatchProfiles.Add(_receiver);
                _receiver.MatchProfiles.Add(this);
            }
        }
        else
        {
            this.SkippedProfiles.Add(_receiver);
        }
    }

    public void ShowSkippedProfiles()
    {
        System.Console.WriteLine("-----------");
        foreach (Profile p in this.SkippedProfiles)
        {
            Console.WriteLine(p.Name);
        }
    }

    public void ShowLikedProfiles()
    {
        System.Console.WriteLine("-----------");
        foreach (Profile p in this.LikedProfiles)
        {
            Console.WriteLine(p.Name);
        }
    }

    public void ShowMatched()
    {
        System.Console.WriteLine("-----------");
        foreach (Profile p in this.MatchProfiles)
        {
            Console.WriteLine(p.Name);
        }
    }

    public bool ProfileInLikes(Profile _p)
    {
        foreach (Profile p in this.LikedProfiles)
        {
            if (p.Equals(_p))
            {
                return true;
            }
        }

        return false;
    }

    public void ShowPotentialList(List<Profile> _allprofiles)
    {
        foreach (Profile p in _allprofiles)
        {
            if (
                this.PrefGender == p.Gender
                && p.PrefGender == this.Gender
                && !this.LikedProfiles.Contains(p)
                && !p.Equals(this)
            )
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}