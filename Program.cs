//*****************************************************************************
//** 2337. Move Pieces to Obtain a String     leetcode                       **
//*****************************************************************************

bool canChange(char* start, char* target)
{
    int n = strlen(start);
    int i = 0, j = 0;

    while (1) 
    {
        while (i < n && start[i] == '_') 
        {
            i++;
        }
        while (j < n && target[j] == '_') 
        {
            j++;
        }

        if (i == n && j == n) 
        {
            return true;
        }

        if (i == n || j == n || start[i] != target[j]) 
        {
            return false;
        }

        if (start[i] == 'L' && i < j) 
        {
            return false;
        }
        if (start[i] == 'R' && i > j) 
        {
            return false;
        }

        i++;
        j++;
    }
}