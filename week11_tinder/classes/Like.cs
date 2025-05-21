namespace MyAppNamespace;

internal class Like
{
    // properties 
    public DateTime Date { get; set; }
    public Profile Receiver { get; set; }
    public Profile Sender { get; set; }
    public Boolean IsLiked { get; set; }

    // constructor 
    public Like(Profile _receiver, Profile _sender, Boolean _isliked)
    {
        this.Date = DateTime.Now;
        this.Receiver = _receiver;
        this.Sender = _sender;
        this.IsLiked = _isliked;

        // comment
    }
}