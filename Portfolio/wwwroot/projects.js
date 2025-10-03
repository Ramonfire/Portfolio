// Fetch and display projects, hiding IDs and highlighting all https links in the description
fetch('/omarZaida/projects')
    .then(res => res.json())
    .then(data => {
        if (!data || data.length === 0) {
            document.getElementById('projects-container').innerHTML = '<p>No projects found.</p>';
            return;
        }
        let html = '<div class="row">';
        console.log(data)
        data.forEach(proj => {
            // Use correct property names from your model
            const { Id, name, link, isHighlight } = proj;

            // Regex to match all https links ending with | or end of string
            const linkRegex = /(https[^\|]+)\|?/g;
            let links = [];
            let desc = link || '';
            let match;
            while ((match = linkRegex.exec(desc)) !== null) {
                links.push(match[1].trim());
            }
            // Remove the links from the description
            let descWithoutLinks = desc.replace(linkRegex, '').trim();

            html += `
                <div class="col-md-6 mb-3">
                    <div class="card h-100 shadow-sm">
                        <div class="card-body">
                            <h5 class="card-title">${name}</h5>
                            <p class="card-text">${descWithoutLinks}</p>
                            ${links.length > 0 ? `
                                <div class="mt-2">
                                    ${links.map(l => `
                                        <a href="${l}" target="_blank" class="btn btn-dark btn-sm me-2 d-inline-flex align-items-center">
                                            <i class="bi bi-github me-1"></i> ${l}
                                        </a>
                                    `).join('')}
                                </div>
                            ` : ''}
                        </div>
                    </div>
                </div>
            `;
        });
        html += '</div>';
        document.getElementById('projects-container').innerHTML = html;
    })
    .catch(() => {
        document.getElementById('projects-container').innerHTML = '<p class="text-danger">Failed to load projects.</p>';
    });