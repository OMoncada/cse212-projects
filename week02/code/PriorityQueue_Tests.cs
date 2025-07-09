using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue several items with different priorties and see if they come out in correct priority order
    // Expected Result: FIFO order (first in, first out)
    // Defect(s) Found: Had to change the priority queue to make sure the comparison was flipped to show more urgest numbers
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Task A", 3);
        priorityQueue.Enqueue("Task B", 1);
        priorityQueue.Enqueue("Task C", 2);

        // Expected dequeue order: Task A, Task C, Task B
        Assert.AreEqual("Task A", priorityQueue.Dequeue());
        Assert.AreEqual("Task C", priorityQueue.Dequeue());
        Assert.AreEqual("Task B", priorityQueue.Dequeue());
    }


    [TestMethod]
    // Scenario: Enqueue multiple items with same priority and see if they come out in insertion order
    // Expected Result: FIFO order will be the result
    // Defect(s) Found: Didn't work at first but was able to adjust the comparision <> to make sure the lower priority numbers were more urgent

    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 1);
        priorityQueue.Enqueue("Second", 1);
        priorityQueue.Enqueue("Third", 1);

        // All same priority, expect FIFO
        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }


    // Add more test cases as needed below.
}