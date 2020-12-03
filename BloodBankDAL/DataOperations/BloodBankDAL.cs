using BloodBankCodeFirstFromDB;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BloodBankDAL.DataOperations
{
    public class BloodBankDAL: SqlDataAccessLayer
    {
		/// <summary>
		/// Insert a car into the database
		/// </summary>
		/// <param name="car"></param>
		public void InsertAuto(Donation donation)
		{
			// need to allow id to be inserted, so set identity_insert to be on

			SetIdentityInsert("Inventory", true);

			string insertCommand = "Insert Into Inventory (DonationId, DonorId, BloodTypeId, DonationDate,DonationBloodVolume) Values" +
				$"('{donation.DonationId}','{donation.DonorId}', '{donation.BloodTypeId}','{donation.DonationDate}', '{donation.DonationBloodVolume}')";

			Debug.WriteLine("InsertAuto: " + insertCommand);

			// Execute using our connection.
			using (SqlCommand sqlCommand = new SqlCommand(insertCommand, sqlConnection))
			{
				try
				{
					sqlCommand.ExecuteNonQuery();
				}
				catch (SqlException ex)
				{
					Exception error = new Exception("Failure: " + sqlCommand.CommandText, ex);
					throw error;
				}
			}

			// now set identity_insert back to off

			SetIdentityInsert("Inventory", false);
		}

		/// <summary>
		/// Insert a car into the database using string arguments 
		/// and parameterized arguments for the sql insert command
		/// </summary>
		/// <param name="carColor">Color</param>
		/// <param name="carMake">Make</param>
		/// <param name="carName">Name of the car</param>
		public void InsertAuto(string carColor, string carMake, string carName)
		{
			// Note the "placeholders" in the SQL query.
			string insertCommand = "Insert Into Inventory" +
							"(Make, Color, Name) Values" +
							"(@Make, @Color, @Name)";

			// This command will have internal parameters.
			using (SqlCommand sqlCommand = new SqlCommand(insertCommand, sqlConnection))
			{
				// Fill params collection.
				sqlCommand.Parameters.Add(new SqlParameter
				{
					ParameterName = "@Make",
					Value = carMake,
					SqlDbType = SqlDbType.Char,
					Size = 10
				});

				sqlCommand.Parameters.Add(new SqlParameter
				{
					ParameterName = "@Color",
					Value = carColor,
					SqlDbType = SqlDbType.Char,
					Size = 10
				});

				sqlCommand.Parameters.Add(new SqlParameter
				{
					ParameterName = "@Name",
					Value = carName,
					SqlDbType = SqlDbType.Char,
					Size = 10
				});

				Debug.WriteLine("InsertAuto: " + sqlCommand.CommandText);

				sqlCommand.ExecuteNonQuery();
			}
		}

		/// <summary>
		/// Delete a car by its Id
		/// </summary>
		/// <param name="id">Car Id</param>

		public void DeleteCar(int id)
		{
			// Get ID of car to delete, then do so.
			string deleteCommand = $"Delete from Inventory where CarId = '{id}'";

			Debug.WriteLine("DeleteCar: " + deleteCommand);

			using (SqlCommand sqlCommand = new SqlCommand(deleteCommand, sqlConnection))
			{
				try
				{
					sqlCommand.ExecuteNonQuery();
				}
				catch (SqlException ex)
				{
					Exception error = new Exception("Sorry! That car is on order!", ex);
					throw error;
				}
			}
		}

		/// <summary>
		/// Change the car name
		/// </summary>
		/// <param name="id">CarId</param>
		/// <param name="newName">New name of the car</param>
		public void UpdateCarName(int id, string newName)
		{
			// Get ID of car to modify and new pet name.
			string updateCommand = $"Update Inventory Set Name = '{newName}' Where CarId = '{id}'";

			Debug.WriteLine("UpdateCarName: " + updateCommand);

			using (SqlCommand sqlCommand = new SqlCommand(updateCommand, sqlConnection))
			{
				sqlCommand.ExecuteNonQuery();
			}
		}

		/// <summary>
		/// Get a list of cars in inventory
		/// </summary>
		/// <returns>A list of cars</returns>
		//public List<Car> GetAllInventoryAsList()
		//{
		//	// This will hold the records.
		//	List<Car> inv = new List<Car>();

		//	// Prep command object.
		//	string selectCommand = "Select * From Inventory";

		//	Debug.WriteLine("GetAllInventoryAsList: " + selectCommand);

		//	using (SqlCommand sqlCommand = new SqlCommand(selectCommand, sqlConnection))
		//	{
		//		SqlDataReader dataReader = sqlCommand.ExecuteReader();
		//		while (dataReader.Read())
		//		{
		//			inv.Add(new Car
		//			{
		//				CarId = (int)dataReader["CarId"],
		//				Color = (string)dataReader["Color"],
		//				Make = (string)dataReader["Make"],
		//				Name = (string)dataReader["Name"]
		//			});
		//		}
		//		dataReader.Close();
		//	}
		//	return inv;
		//}

		/// <summary>
		/// Get a list of customers
		/// </summary>
		/// <returns>customer list</returns>
		//public List<Customer> GetAllCustomersAsList()
		//{
		//	// This will hold the records.
		//	List<Customer> customer = new List<Customer>();

		//	// Prep command object.
		//	string selectCommand = "Select * From Customers";

		//	Debug.WriteLine("GetAllCustomersAsList: " + selectCommand);

		//	using (SqlCommand sqlCommand = new SqlCommand(selectCommand, sqlConnection))
		//	{
		//		SqlDataReader dataReader = sqlCommand.ExecuteReader();
		//		while (dataReader.Read())
		//		{
		//			customer.Add(new Customer
		//			{
		//				CustId = (int)dataReader["CustId"],
		//				FirstName = (string)dataReader["FirstName"],
		//				LastName = (string)dataReader["LastName"],
		//			});
		//		}
		//		dataReader.Close();
		//	}
		//	return customer;
		//}

		/// <summary>
		/// Get the car name associated with a CarId.
		/// Demonstrates use of stored procedure and parameters
		/// </summary>
		/// <param name="carId">CarId</param>
		/// <returns>The name of the car</returns>
		public string LookUpName(int carId)
		{
			string carName;

			// Establish name of stored proc.
			using (SqlCommand sqlCommand = new SqlCommand("GetName", sqlConnection))
			{

				sqlCommand.CommandType = CommandType.StoredProcedure;

				// Input param.
				sqlCommand.Parameters.Add(new SqlParameter
				{
					ParameterName = "@carId",
					SqlDbType = SqlDbType.Int,
					Value = carId,
					Direction = ParameterDirection.Input
				});

				// Output param.
				sqlCommand.Parameters.Add(new SqlParameter
				{
					ParameterName = "@name",
					SqlDbType = SqlDbType.Char,
					Size = 10,
					Direction = ParameterDirection.Output
				});

				Debug.WriteLine("LookUpName: " +
					sqlCommand.CommandText + " " +
					sqlCommand.Parameters["@carId"] +
					" " + sqlCommand.Parameters["@carId"].Value);

				// Execute the stored proc.
				sqlCommand.ExecuteNonQuery();

				// Return output param.
				carName = (string)sqlCommand.Parameters["@name"].Value;
			}
			return carName;
		}

		/// <summary>
		/// Identify a customer as a credit risk, and move them
		/// to the CreditRisks table
		/// </summary>
		/// <param name="throwEx"></param>
		/// <param name="custId"></param>
		/// <returns>false if the customer does not exist, or the transaction failed</returns>
		public bool ProcessCreditRisk(bool throwEx, int custId)
		{
			// First, look up current name based on customer ID.
			string firstName;
			string lastName;

			var commandSelect =
				new SqlCommand($"Select * from Customers where CustId = {custId}", sqlConnection);

			Debug.WriteLine("Process CreditRisk: " + commandSelect.CommandText);

			using (var dataReader = commandSelect.ExecuteReader())
			{
				if (dataReader.HasRows)
				{
					dataReader.Read();
					firstName = (string)dataReader["FirstName"];
					lastName = (string)dataReader["LastName"];
				}
				else
				{
					return false;
				}
			}

			// Create command objects that represent each step of the operation.
			var commandRemove =
				new SqlCommand($"Delete from Customers where CustId = {custId}",
				sqlConnection);

			var commandInsert =
				new SqlCommand("Insert Into CreditRisks" +
				$"(FirstName, LastName) Values('{firstName}', '{lastName}')",
				sqlConnection);

			Debug.WriteLine("Process CreditRisk: " + commandRemove.CommandText);
			Debug.WriteLine("Process CreditRisk: " + commandInsert.CommandText);

			// We will get this from the connection object.
			SqlTransaction transaction = null;
			try
			{
				transaction = sqlConnection.BeginTransaction();

				// Enlist the commands into this transaction.
				commandInsert.Transaction = transaction;
				commandRemove.Transaction = transaction;

				// Execute the commands.
				commandInsert.ExecuteNonQuery();
				commandRemove.ExecuteNonQuery();

				// Simulate error.
				if (throwEx)
				{
					throw new Exception("Database error: Transaction failed");
				}

				// Commit it!
				transaction.Commit();
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Debug.WriteLine("Process CreditRisk: transaction failed, check to see if Orders table has this customer");

				// Any error will roll back transaction.  Using the new conditional access operator to check for null.
				transaction?.Rollback();
				return false;
			}
		}
	}
}

