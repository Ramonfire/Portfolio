// Fetch and display work experiences, hiding IDs
fetch('/omarZaida/workexperiences')
    .then(res => res.json())
    .then(data => {
        if (!data || data.length === 0) {
            document.getElementById('workexperiences-container').innerHTML = '<p>No work experiences found.</p>';
            return;
        }

        function formatDate(dateStr) {
            if (!dateStr) return 'Present';
            const date = new Date(dateStr);
            return date.toLocaleString('default', { month: 'short', year: 'numeric' });
        }

        let html = '<div class="row">';
        data.forEach(exp => {
            const { title, companyName, startDate, endDate, description } = exp;

            const start = formatDate(startDate);
            const end = formatDate(endDate);

            // Split lines and join with <br>
            const formattedDescription = description.split("\n").join("<br>");

            html += `
                <div class="col-md-6 mb-3">
                    <div class="card h-100">
                        <div class="card-body">
                            <h5 class="card-title">${title}</h5>
                            <h6 class="card-subtitle mb-2 text-muted">${companyName}</h6>
                            <p class="card-text"><strong>${start} - ${end}</strong></p>
                            <p class="card-text">${formattedDescription}</p>
                        </div>
                    </div>
                </div>
            `;
        });
        html += '</div>';
        document.getElementById('workexperiences-container').innerHTML = html;
    })
    .catch(() => {
        document.getElementById('workexperiences-container').innerHTML = '<p class="text-danger">Failed to load work experiences.</p>';
    });
