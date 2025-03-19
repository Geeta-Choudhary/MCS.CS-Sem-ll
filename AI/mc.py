def is_invalid_state(m, c):
    return c > m > 0


def main():
    lM, lC, rM, rC = 3, 3, 0, 0

    while True:
        if (rM + rC) == 6:
            print("Win..!!!")
            break

        while True:
            print("\n===================================")
            print(f"LM : {lM} & LC : {lC} && RM : {rM} & RC : {rC}")
            print("===================================\n")

            print("Left to Right : ")
            uM = int(input("Enter number of Missionaries: "))
            uC = int(input("Enter number of Cannibals: "))

            if uM == 0 and uC == 0:
                print("Empty travel not possible")
                print("Re-enter : ")
            elif (uM + uC <= 2) and (lM - uM >= 0) and (lC - uC >= 0):
                lM -= uM
                lC -= uC
                rM += uM
                rC += uC
                break
            else:
                print("Wrong input re-enter : ")

        if (rM + rC) == 6:
            print("Win..!!!")
            break

        if is_invalid_state(lM, lC) or is_invalid_state(rM, rC):
            print("Cannibals eat missionaries...")
            break

        while True:
            print("\n===================================")
            print(f"LM : {lM} & LC : {lC} && RM : {rM} & RC : {rC}")
            print("===================================\n")

            print("Right To Left : ")
            userM = int(input("Enter number of Missionaries: "))
            userC = int(input("Enter number of Cannibals: "))

            if userM == 0 and userC == 0:
                print("Empty travel not possible")
                print("Re-enter : ")
            elif (userM + userC <= 2) and (rM - userM >= 0) and (rC - userC >= 0):
                lM += userM
                lC += userC
                rM -= userM
                rC -= userC
                break
            else:
                print("Wrong input re-enter : ")

        if is_invalid_state(lM, lC) or is_invalid_state(rM, rC):
            print("Cannibals eat missionaries...")
            break


if __name__ == "__main__":
    main()
