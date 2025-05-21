//date and time
function updateDateTime() {
  const now = new Date();
  const time = now.toLocaleTimeString("en-IN", { hour12: false });
  const date = now.toLocaleDateString("en-GB", {
    day: "2-digit",
    month: "short",
    year: "numeric",
  });

  document.getElementById("time").innerHTML = time;
  document.getElementById("date").innerHTML = date;
}

document.addEventListener("DOMContentLoaded", function () {
  updateDateTime();
  setInterval(updateDateTime, 1000);
});

// Donut Chart for Budget
const ctx = document.getElementById("budgetChart").getContext("2d");
new Chart(ctx, {
  type: "doughnut",
  data: {
    datasets: [
      {
        data: [92, 8],
        backgroundColor: ["#a659f3", "#eaeaea"],
        borderWidth: 0,
      },
    ],
  },
  options: {
    cutout: "92%",
    plugins: { legend: { display: false } },
  },
});

// Line Chart for Monthly Consumed Amount
const monthlyLine = document
  .getElementById("monthlyLineChart")
  .getContext("2d");
new Chart(monthlyLine, {
  type: "line",
  data: {
    labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun"],
    datasets: [
      {
        label: "Consumed",
        data: [200000, 150000, 300000, 250000, 100000, 0],
        borderColor: "#a659f3",
        backgroundColor: "#e4c3ff",
        tension: 0.4,
        fill: true,
        pointBackgroundColor: "#a659f3",
      },
    ],
  },
  options: {
    plugins: { legend: { display: false } },
  },
});

// Bar Chart for Students Attendance
const studentsBar = document
  .getElementById("studentsBarChart")
  .getContext("2d");
new Chart(studentsBar, {
  type: "bar",
  data: {
    labels: ["A", "B", "C", "D", "E"],
    datasets: [
      {
        data: [5, 7, 4, 6, 5],
        backgroundColor: "#a659f3",
        borderRadius: 8,
      },
    ],
  },
  options: {
    plugins: { legend: { display: false } },
    scales: { y: { beginAtZero: true } },
  },
});


