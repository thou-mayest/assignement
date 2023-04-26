int current_depth=1;
//depth list that will hold all the values
List<int> depths = new List<int>();

branch root = new branch();
branch firstChild1 = new branch();
branch firstchild2 = new branch();

branch secondChild = new branch();
branch secondChild2 = new branch();
branch secondChild3 = new branch();
branch secondChild4 = new branch();

branch thirdChild = new branch();
branch thirdChild2 = new branch();
branch thirdChild3 = new branch();

branch fourthChild = new branch();

root.branches.Add(firstChild1);
root.branches.Add(firstchild2);

firstChild1.branches.Add(secondChild);
firstChild1.branches.Add(secondChild2);
firstChild1.branches.Add(secondChild3);

secondChild.branches.Add(thirdChild);
secondChild2.branches.Add(thirdChild2);
secondChild2.branches.Add(thirdChild3);

thirdChild3.branches.Add(fourthChild);


CountDepth(root);
// return the maximum value from the list:
Console.WriteLine(depths.Max());

void CountDepth(branch b)
{
    
    foreach(var branch in b.branches)
    {
        current_depth++;    
        if(branch.branches.Count > 0)
        {
            
            CountDepth(branch);
        }
        else
        {
            current_depth++;
            // instead of console write current_depth we will add that to the list :
            depths.Add(current_depth);
            current_depth =1;
        }
        
    }
}
class branch
{
    public List<branch> branches = new List<branch>();
}