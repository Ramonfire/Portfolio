fetch('/omarZaida/skills')
    .then(res => res.json())
    .then(data => {
        if (!data || data.length === 0) {
            document.getElementById('skills-container').innerHTML = '<p>No skills found.</p>';
            return;
        }

        // Group skills by category
        const grouped = {};
        data.forEach(skill => {
            const categoryName = skill.category?.categoryName || "Uncategorized";
            if (!grouped[categoryName]) {
                grouped[categoryName] = [];
            }
            grouped[categoryName].push(skill);
        });
        console.log(grouped)
        // Build HTML
        let html = '<div class="container">';
        const colors = ['#f8d7da', '#d1ecf1', '#d4edda', '#fff3cd']; // example colors

        Object.entries(grouped).forEach(([category, skills], index) => {
            const color = colors[index % colors.length]; // cycle through colors
            html += `
        <div class="row align-items-center mb-4" style="background-color: ${color}; padding: 10px; border-radius: 5px;">
            <!-- Category Title -->
            <div class="col-md-2">
                <h5 class="mb-0">${category}</h5>
            </div>

            <!-- Skills beside category -->
            <div class="col-md-10 d-flex flex-wrap gap-2">
                ${skills.map(skill => `
                    <span class="badge bg-primary p-2">${skill.skillName}</span>
                `).join('')}
            </div>
        </div>
    `;
        });

        html += '</div>';

        document.getElementById('skills-container').innerHTML = html;
    })
    .catch(() => {
        document.getElementById('skills-container').innerHTML = '<p class="text-danger">Failed to load skills.</p>';
    });
