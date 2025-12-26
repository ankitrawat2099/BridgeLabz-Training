class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if(needle == ""){
            return 0;}
        return haystack.IndexOf(needle);
    }
}
