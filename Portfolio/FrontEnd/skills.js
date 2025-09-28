    // Fetch and display skills, hiding IDs
fetch('/omarZaida/skills')
    .then(res => res.json())
    .then(data => {
        if (!data || data.length === 0) {
            document.getElementById('profile-container').innerHTML = '<p>No profile  found.</p>';
            return;
        }
        
        let html = '<div class="row">';
        console.log(data);
        data.forEach(skill => {
            const { Id, CategoryId, ...displaySkill } = skill;
            html += `
                <div class="col-md-4 mb-3">
                    <div class="card h-100">
                        <div class="card-body">
                            <h5 class="card-title">${displaySkill.skillName}</h5>
                            ${displaySkill.category && displaySkill.category.categoryName ? `<p class="card-text">Category: ${displaySkill.category.categoryName}</p>` : ''}
                        </div>
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