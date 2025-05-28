def sum_mul(n, m):

    if (n <= 0 or m <= 0):
        return "INVALID"

    if (n == m or n > m):
        return 0

    total_sum = 0

    for multiple in range(n, m, n):
        total_sum += multiple

    return total_sum
        