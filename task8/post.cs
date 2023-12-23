class Post{

public string Tittle { get; set; }
public string  Description { get; set; }

public int LikeCount = 0;
public List<string> Comments;
public bool IsPublished { get; set; }

public void Like(){
    LikeCount++;
}

public void Publish(bool IsPublished){

System.Console.WriteLine("THE post is publihed");
 this.IsPublished=IsPublished;

}

public void Comment (string text){

if(Comments==null) Comments=new List<string>();
    Comments.Add(text);
}



}