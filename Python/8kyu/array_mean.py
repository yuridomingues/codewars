nums = [1, 3, 5, 7]


def find_average(nums):
    for i in enumerate(nums):
        print(i)
    return sum(nums) / len(nums) if nums else 0


if __name__ == "__main__":
    average = find_average(nums)
    print(f"The average of {nums} is {average}")
