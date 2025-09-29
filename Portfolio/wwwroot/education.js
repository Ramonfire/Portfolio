// Fetch and display education, hiding IDs
fetch('/omarZaida/educations')
    .then(res => res.json())
    .then(data => {
        if (!data || data.length === 0) {
            document.getElementById('education-container').innerHTML = '<p>No education found.</p>';
            return;
        }
        let html = '<div class="row">';
        var edu = data[0]
        data.forEach(edu => {
            const { Id, organization, organizationAdress, description, certificateLink } = edu;
            html += `
                <div class="col-md-6 mb-3">
                    <div class="card h-100">
                        <div class="card-body">
                            <h5 class="card-title">${organization}</h5>
                            <h6 class="card-subtitle mb-2 text-muted">${organizationAdress}</h6>
                            <p class="card-text">${description}</p>
                            ${certificateLink ? `
                                <div class="mt-2">
                                    <small>
                                        <a href="${certificateLink}" target="_blank" class="text-secondary">View Certificate</a>
                                    </small>
                                </div>
                            ` : ''}
                        </div>
                    </div>
                </div>
            `;
        });
        html += '</div>';
        document.getElementById('education-container').innerHTML = html;
    })
    .catch(() => {
        document.getElementById('education-container').innerHTML = '<p class="text-danger">Failed to load education.</p>';
    });