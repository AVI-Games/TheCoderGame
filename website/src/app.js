// Modules needed for the webserver
const express = require("express");
const mysql = require("mysql");
const cors = require("cors");
const path = require("path");

const app = express();
const port = process.env.PORT || 5000;

// Define paths
const publicPath = path.join(__dirname, "..");

// We use cors to prevent security issues
app.use(cors());
app.use(express.json());
app.use(express.static(publicPath));

// This is needed when we send forms to the api, so that the api knows how to process the body of the form
app.use(express.urlencoded({ extended: true }));

function connectToDB() {
	// Change the data to match your configuration.
	try {
		return mysql.createConnection({
			host: "localhost",
			user: "Equipo_1",
			password: "Equipo_1_Super_Dios",
			database: "game_metrics",
		});
	} catch (error) {
		console.log(error);
	}
}

// Render index.html
app.get("", (req, res) => {
	res.sendFile(publicPath + "/index.html");
});

// This api recieves data in a form, and inserts it to the database.
app.post("/api/gameConnect", (request, response) => {
	try {
		console.log("Request data:", request.body);
		let connection = connectToDB();
		connection.connect();

		// Conveniently, the names of the fields match the names of the database columns, and we can insert the data as follows:
		const query = connection.query(
			"insert into game_data set ?",
			request.body,
			(error, results, fields) => {
				// If there are no errors, we send a message back to unity that the data was inserted correctly.
				if (error) console.log(error);
				else response.json({ message: "Data inserted correctly." });
			}
		);

		// Log everything in the server console.
		console.log(query.sql);
		connection.end();
	} catch (error) {
		console.log(error);
		connection.end();
		response.json(error);
	}
});

app.get("/api/select", (req, res) => {
	let select = "SELECT * FROM game_data;";
	const connection = connectToDB();
	let query = connection.query(select, function (error, results) {
		if (error) throw error;

		return res.json(results);
		// console.log(res);
	});
});

app.listen(port, () => {
	console.log(`App listening at http://localhost:${port}`);
});
