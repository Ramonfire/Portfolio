// Fetch and display mastered languages, hiding IDs
fetch('/omarZaida/masteredlanguages')
    .then(res => res.json())
    .then(data => {
        if (!data || data.length === 0) {
            document.getElementById('languages-container').innerHTML = '<p>No languages found.</p>';
            return;
        }
        let html = '<div class="row">';
        var lang = data[0];
        data.forEach(lang => {
            const { Id, language, level } = lang;
            let levelText = '';
            switch (level) {
                case 3: levelText = 'Native'; break;
                case 2: levelText = 'Professional'; break;
                case 1: levelText = 'Basics'; break;
                case 0: default: levelText = 'None'; break;
            }
            html += `
                <div class="col-md-4 mb-3">
                    <div class="card h-100">
                        <div class="card-body">
                            <h5 class="card-title">${language}</h5>
                            <p class="card-text">Level: ${levelText}</p>
                        </div>
                    </div>
                </div>
            `;
        });
        html += '</div>';
        document.getElementById('languages-container').innerHTML = html;
    })
    .catch(() => {
        document.getElementById('languages-container').innerHTML = '<p class="text-danger">Failed to load languages.</p>';
    });