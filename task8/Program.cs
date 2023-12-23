
var post1=new Post();
post1.Tittle="post1";
post1.Description="this is post 1";
post1.Comment("i love my book 1");
post1.Comment("i love your book 1");
post1.Like();
post1.Like();
post1.Like();
var post2=new Post();
post2.Tittle="post2";
post2.Description="this is post2";
post2.Comment("i love 2 ");
post2.Comment("i love your 2");
post2.Like();
post2.Like();
var post3=new Post();
post3.Tittle="post3";
post3.Description="this is post 3";
post3.Comment("i love this book 3");
post3.Comment("i ");
post3.Like();
post3.Like();
post3.Like();
post3.Like();
var post4=new Post();
post4.Tittle="post4";
post4.Description="this is post 4";
post4.Comment("i love this book 4");
post4.Comment("i ");
post4.Like();
post4.Like();
post4.Like();
post4.Like();
post4.Like();
var post5=new Post();
post5.Tittle="post5";
post5.Description="this is post 5";
post5.Comment("i love this book 5");
post5.Comment("i ");
post5.Like();
post5.Like();
post5.Like();
post5.Like();
post5.Like();


foreach (var item in post1.Comments)
{
    System.Console.WriteLine(item);
    
}
System.Console.WriteLine(post1.LikeCount+"\n --------------------------------------------------");

post1.Publish(true);



List<Post> spiska=new List<Post>();
spiska.Add(post1);
spiska.Add(post2);
spiska.Add(post3);
spiska.Add(post4);
spiska.Add(post5);

foreach (var item in spiska)
{
    System.Console.WriteLine(item.Tittle);
    System.Console.WriteLine(item.LikeCount);
    System.Console.WriteLine(item.Description);
}






