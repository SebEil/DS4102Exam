<template>
    <section>
        <h2>Overview of all things in the troop</h2>
        <mission-list></mission-list>
        <soldier-list></soldier-list>
    </section>
</template>

<script>
import MissionList from "../components/Missions/MissionList.vue"
import SoldierList from "../components/Soldiers/SoldierItem.vue"

export default {
    components: {
        MissionList,
        SoldierList
    }
}
</script>