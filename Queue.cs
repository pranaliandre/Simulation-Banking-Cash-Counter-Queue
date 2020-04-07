using System;
using System.Collections.Generic;
using System.Text;

namespace Simulation_Banking_Cash_counter_Queue
{
	public class Queue
	{
		int front, rear, length;
		int space;
		int[] array;
		/// <summary>
		/// create a new class for queue
		/// </summary>
		/// <param name="space"></param>
		public Queue(int space)
		{
			this.space = space;
			front = 0;
			rear = 0;
			length = 0;
			array = new int[this.space];
		}
		/// <summary>
		/// method to check queue is full or not
		/// </summary>
		/// <param name="queue"></param>
		/// <returns></returns>
		public Boolean IsFull(Queue queue)
		{
			return (queue.length == queue.space);
		}
		/// <summary>
		/// method to check queue is empty or not
		/// </summary>
		/// <param name="queue"></param>
		/// <returns></returns>
		public Boolean IsEmpty(Queue queue)
		{
			return (queue.length == 0);
		}
		/// <summary>
		/// method to add balance in queue
		/// </summary>
		/// <param name="balance"></param>
		public void Enqueue(int balance)
		{
			if (IsFull(this))
			{
				return;
			}
			else
			{
				array[this.rear] = balance;
				this.rear = this.rear + 1;
				this.length = length + 1;
			}
		}
		/// <summary>
		/// method to delete balance dequeue
		/// </summary>
		/// <returns></returns>
		public int Dequeue()
		{
			if (IsEmpty(this))
			{
				return 0;
			}
			else
			{


				int balance = this.array[this.front];
				this.front = this.front + 1;
				this.length = length - 1;
				return balance;
			}
		}
		/// <summary>
		/// method to diaplay the queue means queue insert balance or delete balance 
		/// </summary>
		public void Display()
		{
			while (front != rear)
			{
				Console.WriteLine(array[front]);
				front = front + 1;
			}
		}
	}
}
