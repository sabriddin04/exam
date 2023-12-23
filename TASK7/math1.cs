

class math1{
    const double PI=3.14;
    const double E=2.71;

public double ABS(double a){
    if(a>0) return a;
    else return -1*a;
}
public float ABS(float a){
    if(a>0) return a;
    else return -1*a;
}

public int ABS(int a){
    if(a>0) return a;
    else return -1*a;
}

public double POW(double x,double y){
    double sum=1;
   for(int i=0;i<y;i++){
    sum*=x;
   }
   return sum;

}
public double sqrt(double x){

   return Math.Sqrt(x);

}

public  int Max( int a,int b){
    if(a>b) return a; 
    else if(a<b) return b;

}
public int Min(int a, int b){
    if(a>b) return b;
    else if(a<b) return a;

}


}
