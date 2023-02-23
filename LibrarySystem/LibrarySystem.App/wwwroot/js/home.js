//Home
document.addEventListener("DOMContentLoaded", async function () {
	await loadSubCategory(document.querySelector('#Category').value)
	await loadBooksBySubCategoryId(document.querySelector('#SubCategory').value)
});

document.querySelector('#Category').addEventListener('change', async function () {
	await loadSubCategory(this.value);
	await loadBooksBySubCategoryId(document.querySelector('#SubCategory').value)
});

document.querySelector('#SubCategory').addEventListener('change', async function () {
	await loadBooksBySubCategoryId(this.value);
});

async function loadSubCategory(id) {
	await fetch('/api/library/get-subcategories/' + id).then(function (response) {
		return response.json();
	}).then(function (data) {
		var subCategory = document.querySelector('#SubCategory');

		var options = subCategory.querySelectorAll('option');
		options.forEach(o => o.remove());

		for (var i = 0; i < data.length; i++) {
			var option = document.createElement("option");
			option.text = data[i].description;
			option.value = data[i].id;
			subCategory.add(option);
		}
	}).catch(function (err) {
		console.warn('Something went wrong.', err);
	});
}

async function loadBooksBySubCategoryId(id) {
	await fetch('/api/library/get-books-by-sub/' + id).then(function (response) {
		return response.json();
	}).then(function (data) {
		var table = document.querySelector('#booksTable tbody');

		var htmllRow = "";
		var ctr = 1;
		for (var i = 0; i < data.length; i++) {
			htmllRow += "<tr>"
				+ "<td>" + ctr++ + "</td>"
				+ "<td>" + data[i].title + "</td>"
				+ "<td>" + data[i].author + "</td>"
				+ "</tr>";
		}

		table.innerHTML = htmllRow;
	}).catch(function (err) {
		console.warn('Something went wrong.', err);
	});
}