using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Uber {
    public class Complaint {
        public Complaint(int id, string title, string description, DateTime date, bool isAnswered, int userId) {
            this.id = id;
            this.title = title;
            this.description = description;
            this.date = date;
            this.isAnswered = isAnswered;
            this.userId = userId;
        }
        public readonly int id;
        public readonly string title;
        public readonly string description;
        public readonly DateTime date;
        public readonly bool isAnswered;
        public readonly int userId;
    }
    public class ComplaintInstances {
        private int currentIndex;
        private List<Complaint> complaints;
        public ComplaintInstances() {
            complaints = new List<Complaint>();
            currentIndex = -1;
        }
        public void clear() {
            complaints.Clear();
            currentIndex = -1;
        }
        public void fillComplaints(OracleDataReader dataReader) {
            while (dataReader.Read()) {
                complaints.Add(new Complaint(
                    int.Parse(dataReader[0].ToString()),
                    dataReader[1].ToString(),
                    dataReader[2].ToString(),
                    DateTime.Parse(dataReader[3].ToString()),
                    dataReader[4].ToString() == "1",
                    int.Parse(dataReader[5].ToString())
                    ));
            }
            if (complaints.Count > 0) {
                currentIndex = 0;
            }
        }
        public void next() {
            currentIndex++;
            currentIndex %= complaints.Count;
        }
        public void previous() {
            currentIndex += complaints.Count - 1;
            currentIndex %= complaints.Count;
        }
        public void setCurrent(int index) {
            currentIndex = index;
        }
        public Complaint current() {
            return complaints[currentIndex];
        }
        public int getCurrentIndex() {
            return currentIndex;
        }
        public bool empty() {
            return currentIndex == -1;
        }
        public int size() {
            return complaints.Count;
        }
    }
}
