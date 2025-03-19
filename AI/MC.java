import java.util.Scanner;

public class MC {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int lM = 3; 
        int lC = 3; 
        int rM = 0; 
        int rC = 0; 
        int k = 0; 

            while (true) {

                if ((rM + rC) == 6) {
                    System.out.println("Win..!!!");
                    break;
                }

                while (true) {
                    System.out.println("\n===================================");
                    System.out.println("LM : "+lM+" & LC : "+lC+" && RM : "+rM+" & RC : "+rC);
                    System.out.println("===================================\n");

                
                    System.out.println("Left to Right : ");

                    System.out.print("Enter number of Missionaries : ");
                    int uM = scanner.nextInt();
                    System.out.print("Enter number of Cannibals : ");
                    int uC = scanner.nextInt();

                    if (uM == 0 && uC == 0) {
                        System.out.println("Empty travel not possible");
                        System.out.println("Re-enter : ");
                    } else if ((uM + uC <= 2) && (lM - uM >= 0) && (lC - uC >= 0)) {
                        lM -= uM;
                        lC -= uC;
                        rM += uM;
                        rC += uC;
                        break;
                    } else {
                        System.out.println("Wrong input re-enter : ");
                    }
                }

                if ((rM + rC) == 6) {
                    System.out.println("Win..!!!");
                    break;
                }

                if (isInvalidState(lM, lC) || isInvalidState(rM, rC)) {
                    System.out.println("Cannibals eat missionaries...");
                    break;
                }

                while (true) {

                    System.out.println("\n===================================");
                    System.out.println("LM : "+lM+" & LC : "+lC+" && RM : "+rM+" & RC : "+rC);
                    System.out.println("===================================\n");

                    System.out.println("Right To Left : ");
                    System.out.print("Enter number of Missionaries : ");
                    int userM = scanner.nextInt();
                    System.out.print("Enter number of Cannibals : ");
                    int userC = scanner.nextInt();

                    if (userM == 0 && userC == 0) {
                        System.out.println("Empty travel not possible");
                        System.out.println("Re-enter : ");
                    } else if ((userM + userC <= 2) && (rM - userM >= 0) && (rC - userC >= 0)) {
                        lM += userM;
                        lC += userC;
                        rM -= userM;
                        rC -= userC;
                        break; 
                    } else {
                        System.out.println("Wrong input re-enter : ");
                    }
                }

                if (isInvalidState(lM, lC) || isInvalidState(rM, rC)) {
                    System.out.println("Cannibals eat missionaries:");
                    break;
                }
            }
    }

    private static boolean isInvalidState(int m, int c) {
        return (c > m && m > 0); 
    }
}
    

