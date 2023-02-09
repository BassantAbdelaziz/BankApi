async function Account(CustomerAccountId, InitialCredit) {
    const response = await fetch("/Account", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify({ CustomerAccountId, InitialCredit })
    });
    const json = await response.json();
    localStorage.setItem("token", json.token);
}