

    let num="";
let operator="";
function show(value)
{
  document.getElementById("A1").value+=value;
  
}
function btnplus(sign)
{
    
   operator=sign;
    document.getElementById("A1").value+=sign;
   
   
    
}
function btnminus(sign)
{
    
   operator=sign;
    document.getElementById("A1").value+=sign;
   
   
    
}
function btnmulti(sign)
{
    
   operator=sign;
    document.getElementById("A1").value+=sign;
   
   
    
}
function btndivide(sign)
{
    
   operator=sign;
    document.getElementById("A1").value+=sign;
   
   
    
}
function Remider(sign)
{
    operator=sign;
    document.getElementById("A1").value+=sign;
}
function refresh()
{
    document.getElementById("A1").value="";
}
function Return()
{
    let text= document.getElementById("A1").value;
    let number=text.slice(0,-1);
    document.getElementById("A1").value=number;
}

function result()
{
   
    if(operator==="+")
{
    let text=document.getElementById("A1").value;
      let number=text.split("+");
    let num=Number(number[0]);
    let num1=Number(number[1]);
    document.getElementById("A1").value=num+num1;

}
if(operator==="-")
{
    let text=document.getElementById("A1").value;
    let number=text.split("-");
    let num=Number(number[0]);
    let num1=Number(number[1]);
    if(num>num1)
    {
        
       document.getElementById("A1").value=num-num1;
    }
    else{
        console.log("First digit must be bigger");

    }
}
if(operator==="*")
{
    let text=document.getElementById("A1").value;
      let number=text.split("*");
    let num=Number(number[0]);
    let num1=Number(number[1]);
     document.getElementById("A1").value=num*num1;
}
if(operator==="/")
{
    let text=document.getElementById("A1").value;
      let number=text.split("/");
    let num=Number(number[0]);
    let num1=Number(number[1]);
    if(num>num1 && num1 !==0)
       {
        
       document.getElementById("A1").value=num/num1;
       }
       else{
        console.log("First digit must be bigger & last digit can't be a zero");
       }
     
}
if(operator==="%")
{
    let text=document.getElementById("A1").value;
      let number=text.split("%");
    let num=Number(number[0]);
    let num1=Number(number[1]);
    if(num>num1 && num1 !==0)
       {
        
       document.getElementById("A1").value=num%num1;
       }
       else{
        console.log("First digit must be bigger & last digit can't be a zero");
       }
}
else{
    console.log("Equation is not right");
}

   



}

 