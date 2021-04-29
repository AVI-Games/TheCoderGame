"use strict";

// Selectors
const playButton = document.querySelector("#play-button");
const unityContainer = document.querySelector("#unityContainer");
const navLinks = document.querySelectorAll(".navigation__link");
const table = document.querySelector("table");
const tableRow = document
	.querySelector("table")
	.getElementsByTagName("tbody")[0];
const indicatorButton = document.querySelector("#indicator-button");

// Function that opens unity container when play button is pressed
playButton.addEventListener("click", (e) => {
	e.preventDefault();
	playButton.classList.add("hidden");
	unityContainer.classList.remove("hidden");
	UnityLoader.instantiate("unityContainer", "Build/F_Build.json");
});

// Scrolling
navLinks.forEach((link) => {
	link.addEventListener("click", (e) => {
		// Prevent page reset
		e.preventDefault();

		// Get section to scroll to
		const href = link.getAttribute("href");

		// Using scroll into view
		document.querySelector(href).scrollIntoView({
			behavior: "smooth",
		});
	});
});

// Add data to table
let loop = 0;

indicatorButton.addEventListener("click", (e) => {
	// Showing table
	e.preventDefault();
	table.classList.remove("hidden");

	// Inserting data into table
	fetch("/api/select").then((res) => {
		if (!res) {
			console.log("Error, no result delivered. Maybe database connection error?");
		} else {
			res.json().then((data)=>{
				for(let i = loop; i<data.length; i++){
					const newRow = table.insertRow();
					const newCell = newRow.insertCell();
					const newCell2 = newRow.insertCell();
					const newCell3 = newRow.insertCell();
					const newCell4 = newRow.insertCell();
					const newCell5 = newRow.insertCell();
					const newData = document.createTextNode(data[i].idgameData);
					const newData2 = document.createTextNode(data[i].levelNumber);
					const newData3 = document.createTextNode(data[i].resetsInLevel);
					const newData4 = document.createTextNode(data[i].starsWon);
					const newData5 = document.createTextNode(data[i].timeInLevel);
					newCell.appendChild(newData);
					newCell2.appendChild(newData2);
					newCell3.appendChild(newData3);
					newCell4.appendChild(newData4);
					newCell5.appendChild(newData5);
					loop++;
				}
			}
			);
			
		}
	});

});
