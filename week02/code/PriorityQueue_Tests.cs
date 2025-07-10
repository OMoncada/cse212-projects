using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue several items with different priorities and see if they come out in correct priority order
    // Expected Result: Dequeue should return in order of priority: Task A (3), Task C (2), Task B (1)
    // Defect(s) Found: Had to change the priority queue to make sure the comparison was flipped to show higher numbers as more urgent
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Task A", 3);
        priorityQueue.Enqueue("Task B", 1);
        priorityQueue.Enqueue("Task C", 2);

        Assert.AreEqual("Task A", priorityQueue.Dequeue());
        Assert.AreEqual("Task C", priorityQueue.Dequeue());
        Assert.AreEqual("Task B", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with same priority and see if they come out in insertion order
    // Expected Result: FIFO order will be the result (First, Second, Third)
    // Defect(s) Found: Comparison logic had to ensure stability for same-priority items
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 1);
        priorityQueue.Enqueue("Second", 1);
        priorityQueue.Enqueue("Third", 1);

        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue several items with same highest priority; ensure oldest is removed first
    // Expected Result: FIFO order among items with same priority
    // Defect(s) Found: Queue did not preserve insertion order in case of priority tie
    public void TestPriorityQueue_SamePriority_FIFO()
    {
        var queue = new PriorityQueue();

        queue.Enqueue("Item A", 5);
        queue.Enqueue("Item B", 5);
        queue.Enqueue("Item C", 5);

        Assert.AreEqual("Item A", queue.Dequeue());
        Assert.AreEqual("Item B", queue.Dequeue());
        Assert.AreEqual("Item C", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Result: Should throw InvalidOperationException
    // Defect(s) Found: Code did not check for empty state before Dequeue, causing out-of-range error
    public void TestPriorityQueue_EmptyDequeue()
    {
        var queue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => queue.Dequeue());
    }
}
