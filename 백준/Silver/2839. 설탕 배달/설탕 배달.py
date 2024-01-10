n = int(input())

threshold = n // 5

while True:
    temp = n - threshold * 5
    if temp % 3 == 0:
        result = threshold + temp // 3
        break
    
    threshold -= 1
    
    if threshold < 0:
        result = -1
        break


print(result)