
void createroadMatrix(int[,] roadMatrix)
{
    roadMatrix[0, 0] = 0;
    roadMatrix[0, 1] = 31;
    roadMatrix[0, 2] = 28;
    roadMatrix[0, 3] = 0;
    roadMatrix[0, 4] = 0;
    roadMatrix[0, 5] = 0;
    roadMatrix[0, 6] = 0;
    roadMatrix[1, 0] = 31;
    roadMatrix[1, 1] = 0;
    roadMatrix[1, 2] = 0;
    roadMatrix[1, 3] = 19;
    roadMatrix[1, 4] = 0;
    roadMatrix[1, 5] = 32;
    roadMatrix[1, 6] = 0;
    roadMatrix[2, 0] = 28;
    roadMatrix[2, 1] = 0;
    roadMatrix[2, 2] = 0;
    roadMatrix[2, 3] = 20;
    roadMatrix[2, 4] = 23;
    roadMatrix[2, 5] = 0;
    roadMatrix[2, 6] = 0;
    roadMatrix[3, 0] = 0;
    roadMatrix[3, 1] = 19;
    roadMatrix[3, 2] = 20;
    roadMatrix[3, 3] = 0;
    roadMatrix[3, 4] = 0;
    roadMatrix[3, 5] = 0;
    roadMatrix[3, 6] = 40;
    roadMatrix[4, 0] = 0;
    roadMatrix[4, 1] = 0;
    roadMatrix[4, 2] = 23;
    roadMatrix[4, 3] = 0;
    roadMatrix[4, 4] = 0;
    roadMatrix[4, 5] = 0;
    roadMatrix[4, 6] = 27;
    roadMatrix[5, 0] = 0;
    roadMatrix[5, 1] = 32;
    roadMatrix[5, 2] = 0;
    roadMatrix[5, 3] = 0;
    roadMatrix[5, 4] = 0;
    roadMatrix[5, 5] = 0;
    roadMatrix[5, 6] = 23;
    roadMatrix[6, 0] = 0;
    roadMatrix[6, 1] = 0;
    roadMatrix[6, 2] = 0;
    roadMatrix[6, 3] = 40;
    roadMatrix[6, 4] = 27;
    roadMatrix[6, 5] = 23;
    roadMatrix[6, 6] = 0;
}

void createflyMatrix(int[,] roadMatrix)
{
    roadMatrix[0, 0] = 0;
    roadMatrix[0, 1] = 31;
    roadMatrix[0, 2] = 28;
    roadMatrix[0, 3] = 33;
    roadMatrix[0, 4] = 45;
    roadMatrix[0, 5] = 57;
    roadMatrix[0, 6] = 70;
    roadMatrix[1, 0] = 31;
    roadMatrix[1, 1] = 0;
    roadMatrix[1, 2] = 34;
    roadMatrix[1, 3] = 19;
    roadMatrix[1, 4] = 33;
    roadMatrix[1, 5] = 32;
    roadMatrix[1, 6] = 50;
    roadMatrix[2, 0] = 28;
    roadMatrix[2, 1] = 34;
    roadMatrix[2, 2] = 0;
    roadMatrix[2, 3] = 20;
    roadMatrix[2, 4] = 23;
    roadMatrix[2, 5] = 48;
    roadMatrix[2, 6] = 53;
    roadMatrix[3, 0] = 33;
    roadMatrix[3, 1] = 19;
    roadMatrix[3, 2] = 20;
    roadMatrix[3, 3] = 0;
    roadMatrix[3, 4] = 18;
    roadMatrix[3, 5] = 28;
    roadMatrix[3, 6] = 40;
    roadMatrix[4, 0] = 45;
    roadMatrix[4, 1] = 33;
    roadMatrix[4, 2] = 23;
    roadMatrix[4, 3] = 18;
    roadMatrix[4, 4] = 0;
    roadMatrix[4, 5] = 28;
    roadMatrix[4, 6] = 27;
    roadMatrix[5, 0] = 57;
    roadMatrix[5, 1] = 32;
    roadMatrix[5, 2] = 48;
    roadMatrix[5, 3] = 28;
    roadMatrix[5, 4] = 28;
    roadMatrix[5, 5] = 0;
    roadMatrix[5, 6] = 23;
    roadMatrix[6, 0] = 70;
    roadMatrix[6, 1] = 50;
    roadMatrix[6, 2] = 53;
    roadMatrix[6, 3] = 40;
    roadMatrix[6, 4] = 27;
    roadMatrix[6, 5] = 23;
    roadMatrix[6, 6] = 0;
}

void createvisitMatrix(int[,] roadMatrix)
{
    for (int i = 0; i < 7; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            roadMatrix[i, j]=0;
        }
    }
}

void createroadMatrix2(int[,] roadMatrix)
{
    roadMatrix[0, 0] = 0;
    roadMatrix[0, 1] = 34;
    roadMatrix[0, 2] = 0;
    roadMatrix[0, 3] = 43;
    roadMatrix[0, 4] = 36;
    roadMatrix[0, 5] = 0;
    roadMatrix[0, 6] = 0;
    roadMatrix[0, 7] = 0;
    roadMatrix[0, 8] = 0;
    roadMatrix[0, 9] = 0;

    roadMatrix[1, 0] = 34;
    roadMatrix[1, 1] = 0;
    roadMatrix[1, 2] = 30;
    roadMatrix[1, 3] = 16;
    roadMatrix[1, 4] = 0;
    roadMatrix[1, 5] = 49;
    roadMatrix[1, 6] = 0;
    roadMatrix[1, 7] = 0;
    roadMatrix[1, 8] = 0;
    roadMatrix[1, 9] = 0;

    roadMatrix[2, 0] = 0;
    roadMatrix[2, 1] = 30;
    roadMatrix[2, 2] = 0;
    roadMatrix[2, 3] = 0;
    roadMatrix[2, 4] = 0;
    roadMatrix[2, 5] = 31;
    roadMatrix[2, 6] = 0;
    roadMatrix[2, 7] = 0;
    roadMatrix[2, 8] = 0;
    roadMatrix[2, 9] = 0;

    roadMatrix[3, 0] = 43;
    roadMatrix[3, 1] = 16;
    roadMatrix[3, 2] = 0;
    roadMatrix[3, 3] = 0;
    roadMatrix[3, 4] = 0;
    roadMatrix[3, 5] = 0;
    roadMatrix[3, 6] = 0;
    roadMatrix[3, 7] = 41;
    roadMatrix[3, 8] = 0;
    roadMatrix[3, 9] = 0;

    roadMatrix[4, 0] = 36;
    roadMatrix[4, 1] = 0;
    roadMatrix[4, 2] = 0;
    roadMatrix[4, 3] = 0;
    roadMatrix[4, 4] = 0;
    roadMatrix[4, 5] = 0;
    roadMatrix[4, 6] = 22;
    roadMatrix[4, 7] = 0;
    roadMatrix[4, 8] = 0;
    roadMatrix[4, 9] = 0;

    roadMatrix[5, 0] = 0;
    roadMatrix[5, 1] = 49;
    roadMatrix[5, 2] = 31;
    roadMatrix[5, 3] = 0;
    roadMatrix[5, 4] = 0;
    roadMatrix[5, 5] = 0;
    roadMatrix[5, 6] = 59;
    roadMatrix[5, 7] = 0;
    roadMatrix[5, 8] = 30;
    roadMatrix[5, 9] = 0;

    roadMatrix[6, 0] = 0;
    roadMatrix[6, 1] = 0;
    roadMatrix[6, 2] = 0;
    roadMatrix[6, 3] = 0;
    roadMatrix[6, 4] = 22;
    roadMatrix[6, 5] = 59;
    roadMatrix[6, 6] = 0;
    roadMatrix[6, 7] = 30;
    roadMatrix[6, 8] = 0;
    roadMatrix[6, 9] = 25;

    roadMatrix[7, 0] = 0;
    roadMatrix[7, 1] = 0;
    roadMatrix[7, 2] = 0;
    roadMatrix[7, 3] = 41;
    roadMatrix[7, 4] = 0;
    roadMatrix[7, 5] = 0;
    roadMatrix[7, 6] = 30;
    roadMatrix[7, 7] = 0;
    roadMatrix[7, 8] = 15;
    roadMatrix[7, 9] = 32;

    roadMatrix[8, 0] = 0;
    roadMatrix[8, 1] = 0;
    roadMatrix[8, 2] = 0;
    roadMatrix[8, 3] = 0;
    roadMatrix[8, 4] = 0;
    roadMatrix[8, 5] = 30;
    roadMatrix[8, 6] = 0;
    roadMatrix[8, 7] = 15;
    roadMatrix[8, 8] = 0;
    roadMatrix[8, 9] = 55;

    roadMatrix[9, 0] = 0;
    roadMatrix[9, 1] = 0;
    roadMatrix[9, 2] = 0;
    roadMatrix[9, 3] = 0;
    roadMatrix[9, 4] = 0;
    roadMatrix[9, 5] = 0;
    roadMatrix[9, 6] = 25;
    roadMatrix[9, 7] = 32;
    roadMatrix[9, 8] = 55;
    roadMatrix[9, 9] = 0;
}

void createflyMatrix2(int[,] roadMatrix)
{
    roadMatrix[0, 0] = 0;
    roadMatrix[0, 1] = 34;
    roadMatrix[0, 2] = 75;
    roadMatrix[0, 3] = 43;
    roadMatrix[0, 4] = 36;
    roadMatrix[0, 5] = 88;
    roadMatrix[0, 6] = 66;
    roadMatrix[0, 7] = 94;
    roadMatrix[0, 8] = 119;
    roadMatrix[0, 9] = 101;

    roadMatrix[1, 0] = 34;
    roadMatrix[1, 1] = 0;
    roadMatrix[1, 2] = 30;
    roadMatrix[1, 3] = 16;
    roadMatrix[1, 4] = 50;
    roadMatrix[1, 5] = 49;
    roadMatrix[1, 6] = 64;
    roadMatrix[1, 7] = 69;
    roadMatrix[1, 8] = 89;
    roadMatrix[1, 9] = 98;

    roadMatrix[2, 0] = 75;
    roadMatrix[2, 1] = 30;
    roadMatrix[2, 2] = 0;
    roadMatrix[2, 3] = 40;
    roadMatrix[2, 4] = 84;
    roadMatrix[2, 5] = 31;
    roadMatrix[2, 6] = 87;
    roadMatrix[2, 7] = 75;
    roadMatrix[2, 8] = 79;
    roadMatrix[2, 9] = 117;

    roadMatrix[3, 0] = 43;
    roadMatrix[3, 1] = 16;
    roadMatrix[3, 2] = 40;
    roadMatrix[3, 3] = 0;
    roadMatrix[3, 4] = 31;
    roadMatrix[3, 5] = 30;
    roadMatrix[3, 6] = 34;
    roadMatrix[3, 7] = 41;
    roadMatrix[3, 8] = 63;
    roadMatrix[3, 9] = 69;

    roadMatrix[4, 0] = 36;
    roadMatrix[4, 1] = 50;
    roadMatrix[4, 2] = 84;
    roadMatrix[4, 3] = 31;
    roadMatrix[4, 4] = 0;
    roadMatrix[4, 5] = 71;
    roadMatrix[4, 6] = 22;
    roadMatrix[4, 7] = 58;
    roadMatrix[4, 8] = 88;
    roadMatrix[4, 9] = 54;

    roadMatrix[5, 0] = 88;
    roadMatrix[5, 1] = 49;
    roadMatrix[5, 2] = 31;
    roadMatrix[5, 3] = 30;
    roadMatrix[5, 4] = 71;
    roadMatrix[5, 5] = 0;
    roadMatrix[5, 6] = 59;
    roadMatrix[5, 7] = 29;
    roadMatrix[5, 8] = 30;
    roadMatrix[5, 9] = 77;

    roadMatrix[6, 0] = 66;
    roadMatrix[6, 1] = 64;
    roadMatrix[6, 2] = 87;
    roadMatrix[6, 3] = 34;
    roadMatrix[6, 4] = 22;
    roadMatrix[6, 5] = 59;
    roadMatrix[6, 6] = 0;
    roadMatrix[6, 7] = 30;
    roadMatrix[6, 8] = 61;
    roadMatrix[6, 9] = 25;

    roadMatrix[7, 0] = 94;
    roadMatrix[7, 1] = 69;
    roadMatrix[7, 2] = 75;
    roadMatrix[7, 3] = 41;
    roadMatrix[7, 4] = 58;
    roadMatrix[7, 5] = 29;
    roadMatrix[7, 6] = 30;
    roadMatrix[7, 7] = 0;
    roadMatrix[7, 8] = 15;
    roadMatrix[7, 9] = 32;

    roadMatrix[8, 0] = 119;
    roadMatrix[8, 1] = 89;
    roadMatrix[8, 2] = 79;
    roadMatrix[8, 3] = 63;
    roadMatrix[8, 4] = 88;
    roadMatrix[8, 5] = 30;
    roadMatrix[8, 6] = 61;
    roadMatrix[8, 7] = 15;
    roadMatrix[8, 8] = 0;
    roadMatrix[8, 9] = 55;

    roadMatrix[9, 0] = 101;
    roadMatrix[9, 1] = 98;
    roadMatrix[9, 2] = 117;
    roadMatrix[9, 3] = 69;
    roadMatrix[9, 4] = 54;
    roadMatrix[9, 5] = 77;
    roadMatrix[9, 6] = 25;
    roadMatrix[9, 7] = 32;
    roadMatrix[9, 8] = 55;
    roadMatrix[9, 9] = 0;
}

void createvisitMatrix2(int[,] roadMatrix)
{
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            roadMatrix[i, j] = 0;
        }
    }
}

void printMatrix(int[,] matrix, int matrixSize)
{
    Console.WriteLine("------------------------------------------------------");
    for (int i = 0; i < matrixSize; i++)
    {
        for (int j = 0; j < matrixSize; j++)
        {
            Console.Write(" " + matrix[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine("------------------------------------------------------");
}
void controlItMatrix(int[,] matrix, int matrixSize, string type)
{
    for (int i = 0; i < matrixSize; i++)
    {
        for (int j = 0; j < matrixSize; j++)
        {
            if (matrix[i, j] != matrix[j, i])
            {
                Console.WriteLine("----------> "+type+" this matrix is wrong : " + matrix[i, j] + " " + matrix[j, i]);
            }
        }
    }
}

void aStar(int[,] roadMatrix, int[,] flyMatrix, int[,] visitMatrix, int start, int end, int matrixSize)
{
    start = start - 1;
    end = end - 1;
    int toplamYol = 0;
    int tempRoad = 0;
    int biggestPath = 999999;
    int temp_i=0;
    int temp_j=start;
    int i = 0;
    int j = 0;
    for(i = 0; i< matrixSize; i++)
    {
        Console.WriteLine(temp_j + 1 + " went that way.");
        i = temp_j;
        for (j = 0; j< matrixSize; j++)
        {
            if(i != j && roadMatrix[i, j] + flyMatrix[j,end] <= biggestPath && visitMatrix[i,j]==0 && visitMatrix[j,i]==0  && roadMatrix[i, j] !=0)
            {
                biggestPath = roadMatrix[i, j] + flyMatrix[j, end];
                temp_j = j;
                temp_i = i;
                tempRoad = roadMatrix[i, j];
            }
        }
        toplamYol += tempRoad;
        visitMatrix[temp_i, temp_j] = -1;
        visitMatrix[temp_j, temp_i] = -1;
        
        if (temp_j == end)
        {
            Console.WriteLine(temp_j + 1 + " went that way.");
            Console.WriteLine("Cost : " + toplamYol);
            break;
        }
        if (i == matrixSize-1)
        {
            i = 0;
        }
    }
    
}

int[,] roadMatrix = new int[7, 7];
int[,] flyMatrix = new int[7, 7];
int[,] visitMatrix = new int[7, 7];

createvisitMatrix(visitMatrix);
createroadMatrix(roadMatrix);
createflyMatrix(flyMatrix);


int[,] roadMatrix2 = new int[10, 10];
int[,] flyMatrix2 = new int[10, 10];
int[,] visitMatrix2 = new int[10, 10];

createvisitMatrix2(visitMatrix2);
createroadMatrix2(roadMatrix2);
createflyMatrix2(flyMatrix2);

/*Console.WriteLine("First Road Matrix : ");
printMatrix(roadMatrix, 7);
controlItMatrix(roadMatrix, 7, "Road");

Console.WriteLine("\nFirst Flying Matrix : ");
printMatrix(flyMatrix, 7);
controlItMatrix(flyMatrix, 7, "Flying");*/

Console.WriteLine("\nSecond Road Matrix : ");
printMatrix(roadMatrix2, 10);
controlItMatrix(roadMatrix2, 10, "Second Way");

Console.WriteLine("\nSecond Flying Matrix : ");
printMatrix(flyMatrix2, 10);
controlItMatrix(flyMatrix2, 10, "Second Flying ");

/*Console.WriteLine("\n\n----------------------------------------------------------------------\nİlk Harita :\n");
aStar(roadMatrix,flyMatrix,visitMatrix,1,7,7);*/

Console.WriteLine("\n\n----------------------------------------------------------------------\nSecond Map :\n");
aStar(roadMatrix2, flyMatrix2, visitMatrix2, 1,10, 10);



