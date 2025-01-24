def sum_mul(n, m):
    total_sum = 0
    if (n == 0 or n < 0 or m == 0 or m < 0 ):
        return "INVALID"
    if (n == m or n > m):
        return 0

    else:
        n = n + n
        total_sum += n
        if n <= m:
            return total_sum
        