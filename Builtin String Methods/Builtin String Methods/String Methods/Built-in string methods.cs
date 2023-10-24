using System;

/*string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
    int closingPosition =  message.IndexOf("</span>");

//Console.WriteLine(openingPosition);
//Console.WriteLine(closingPosition);

openingPosition += 6;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length)); */

/*string message = "(What if) I am (only interested) in the last (set of parantheses)?";
int openingPosition = message.LastIndexOf('(');
openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length)); */

/*string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    message = message.Substring(closingPosition + 1); 
} */


/* string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching this message : {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 6;
int openingPosition = message.IndexOfAny( openSymbols );
Console.WriteLine($"Found WITHOUT using startPosition : {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny( openSymbols, startPosition );
Console.WriteLine($"Found WITH using startPosition : {message.Substring(openingPosition)}"); */


/* string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
char[] openSymbols = { '[', '{', '(' };
int closingPosition = 0;
while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
    if (openingPosition == -1) break;
    string currentSymbol = message.Substring(openingPosition, 1);
    char matchingSymbol = ' ';
    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;

        case "{":
            matchingSymbol = '}';
            break;

        case "(":
            matchingSymbol = ')';
            break;
    }
    openingPosition += -1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    int length = closingPosition - openingPosition; 
    Console.WriteLine(message.Substring(openingPosition, length));
} */


//Remove ()
/*string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 18);
Console.WriteLine(updatedData); */


//Replace()

/* string message = "This--is--ex-amp-le--data";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message); */


//Challenge to Extract, Replace and Remove Data

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
string quantity = "";
string output = "";

int quantityStart = input.IndexOf("<span>");
int quantityEnd = input.IndexOf("</span>");

quantityStart += "<span>".Length;
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity : {quantity}";

output = input.Replace("&trade;", "&reg;");

int divStart = input.IndexOf("<div>");
int divLength = "<div>".Length;

output = output.Remove(divStart, divLength);

int divCloseStart = output.IndexOf("</div>");
int divCloseLength = "</div>".Length;

output = output.Remove(divCloseStart, divCloseLength);
output = $"Output : {output}";

Console.WriteLine(quantity);
Console.WriteLine(output);






